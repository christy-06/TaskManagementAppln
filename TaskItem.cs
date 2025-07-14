namespace TaskManagementAppln
{
    
        public class TaskItem
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public string Status { get; set; } // "Pending", "Completed"
            public int Priority { get; set; }  // 1 = High, 2 = Medium, 3 = Low
        }
 }


