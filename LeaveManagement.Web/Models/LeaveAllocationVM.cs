using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Required] 
        [Display(Name = "Number Of Days")]
        [Range(1, 50, ErrorMessage = "Invalid Number Entered")]

        public int NumberOfDays { get; set; }

        [Required]
        [Display(Name = "Allocation Period")]
        [Range(1, 50)]

        public int Period   { get; set; }

        public LeaveTypeVM? LeaveType { get; set; }
    }
}
