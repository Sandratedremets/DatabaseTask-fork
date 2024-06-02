using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public Guid HealthCheckId { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public DateTime Date { get; set; }

        [StringLength(50)]
        public string DoctorsName { get; set; }

        public Employee Employee { get; set; }
    }
}