using System.ComponentModel.DataAnnotations;

namespace CommandTrackerApp.Data
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public Person? AssignedMember { get; set; }

        public int Status { get; set; } = 1;

        public DateTime? StartedDate { get; set; }
        
        public DateTime? FinishedDate { get; set; }
    }
}
