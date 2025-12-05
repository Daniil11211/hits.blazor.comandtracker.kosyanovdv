using System.ComponentModel.DataAnnotations;

namespace CommandTrackerApp.Data
{
    public class Person
    {
        public int Id;
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string Position { get; set; } = "Не указана";
    }
}
