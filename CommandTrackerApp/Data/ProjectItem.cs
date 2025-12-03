namespace CommandTrackerApp.Data
{
    public class ProjectItem
    {
        public int Id { get; set; }
        
        public string Title { get; set; } = "Без названия";

        public string Description { get; set; } = "Отстутсвует";

        public DateTime? CreatedDate { get; set; }

        public int CountMembers { get; set; }

        public int Status { get; set; } = 1;

        public int PrivateStatus { get; set; } = 1;
    }
}
