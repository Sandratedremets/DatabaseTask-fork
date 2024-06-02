using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        [Key]
        public Guid VacationId { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeesId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Type { get; set; }

        public Employee Employee { get; set; }
    }
}
