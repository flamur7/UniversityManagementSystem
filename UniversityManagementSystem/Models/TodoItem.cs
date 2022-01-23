using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class TodoItem
    {
        [Key]
        public int TodoItemId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool Completed { get; set; }
    }
}
