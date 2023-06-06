using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string? Id { get; set; }

        [Display(Name = "First Name")]
        public string? Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string? Lastname { get; set; }

        public string? TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string? Email { get; set; }
    }
}
