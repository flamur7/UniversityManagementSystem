using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Bills
    {
        [Key]
        public int BillsId { get; set; }
        public string BillsName { get; set;}
        public string BillsDescription { get; set;}
    }
}
