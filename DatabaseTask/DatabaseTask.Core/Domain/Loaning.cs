using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Loaning
    {
        [Key]
        public Guid LoaningId { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        [ForeignKey("LoanableItems")]
        public Guid LoanableItemsId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Employee Employee { get; set; }

        public LoanableItems LoanableItem { get; set; }
    }
}