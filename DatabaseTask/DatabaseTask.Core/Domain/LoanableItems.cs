using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class LoanableItems
    {
        [Key]
        public Guid LoanableItemId { get; set; }

        public string ItemName { get; set; }

        public bool LoanStatus { get; set; }
    }
}
