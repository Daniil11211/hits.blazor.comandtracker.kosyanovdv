using System.ComponentModel.DataAnnotations;

namespace CommandTrackerApp.Data
{
    public class ProjectItem
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string Description { get; set; } = "Отстутсвует";

        public DateTime? CreatedDate { get; set; }

        [Required]
        public int Status { get; set; } = 1;

        [Required]
        public int PrivateStatus { get; set; } = 1;

        public List<Person>? Members { get; set; }

        public List<TaskItem>? Tasks { get; set; }

    }
}
