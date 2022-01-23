using System.ComponentModel.DataAnnotations;

namespace UniversityManagementSystem.Models
{
    public class Nationality
    {
        [Key]
        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
    }
}
