using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public Guid RequestId { get; set; }

        public string Topic { get; set; }

        public string Content { get; set; }

        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }

        public string Status { get; set; }

        public Employee Employee { get; set; }
    }
}