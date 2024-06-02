
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Suggestion_hints
    {
        [Key]
        public Guid SuggestionId { get; set; }

        public string Topic { get; set; }

        public string Content { get; set; }

        public string Status { get; set; }
    }
}
