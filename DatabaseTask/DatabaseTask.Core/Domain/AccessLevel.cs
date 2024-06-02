using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class AccessLevel
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PermissionList { get; set; }
    }
}
