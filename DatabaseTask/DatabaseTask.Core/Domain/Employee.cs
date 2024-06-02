using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? Birthday { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phonenumber { get; set; }

        [StringLength(11)]
        public string SocialSecurityNumber { get; set; }
        
        [ForeignKey("AccessLevelId")]
        public Guid AccessLevelId { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public AccessLevel AccessLevel { get; set; }

        [ForeignKey("ChildrenId")]
        public Guid ChildrenId { get; set; }

    }
}