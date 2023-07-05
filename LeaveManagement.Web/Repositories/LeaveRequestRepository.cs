using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
       
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly ApplicationDbContext _applicationDbContext;

        public LeaveRequestRepository(ApplicationDbContext context
            , IMapper mapper
            , IHttpContextAccessor httpContextAccessor
            , UserManager<Employee> userManager
            , ILeaveAllocationRepository leaveAllocationRepository) : base(context)
        { 
            _mapper = mapper;
            _contextAccessor = httpContextAccessor;
            _userManager = userManager;
            _leaveAllocationRepository = leaveAllocationRepository;
            _applicationDbContext = context;
        }

        public async Task ChangeApprovalStatus(int leaveRequstId, bool approvalStatus)
        {
            var leaveRequest = await GetAsync(leaveRequstId);
            leaveRequest.Approved = approvalStatus;
            if (approvalStatus)
            {
                var allocation = await _leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays; 
                allocation.NumberOfDays -= daysRequested;
                await _leaveAllocationRepository.UpdateAsync(allocation);
            }
            
            await UpdateAsync(leaveRequest);
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM request)
        {
            var user = await _userManager.GetUserAsync(_contextAccessor?.HttpContext?.User);
            var leaveRequest = _mapper.Map<LeaveRequest>(request);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            await AddAsync(leaveRequest);
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            var leaveRequests = await _applicationDbContext.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewVM
            {
                TotalRequests = leaveRequests.Count(),
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
                PendingRequests = leaveRequests.Count(q => q.Approved == null),
                RejectedRequests = leaveRequests.Count(q => q.Approved == false),
                LeaveRequests = _mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            foreach (var leaveRequest in model.LeaveRequests) 
            {
                leaveRequest.Employee = _mapper.Map<EmployeeListVM>( await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));

            }
            return model;
        }

      

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            return await _applicationDbContext.LeaveRequests.Where(r => r.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await _applicationDbContext.LeaveRequests.Include(q => q.LeaveType).FirstOrDefaultAsync(q => q.Id == id);
            if (leaveRequest == null)
            {
                return null;
            }
            var model = _mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await _userManager.GetUserAsync(_contextAccessor?.HttpContext?.User);
            var allocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var requests =  _mapper.Map<List<LeaveRequestVM>>( await GetAllAsync(user.Id));
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);
            return model;
        }
    }
}
