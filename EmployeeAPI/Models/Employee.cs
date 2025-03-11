using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAPI.Models
{
    [Table("temployee")]
    public class Employee
    {
        [Key]
        public string emp_cd { get; set; } = string.Empty;
        
        public string? fullname { get; set; }
        
        public DateTime? birth_dt { get; set; }
        
        public string? birth_place { get; set; }
        
        public decimal? last_salary { get; set; }
        
        public int? number_of_sibling { get; set; }
        
        public bool? isactive { get; set; }
    }
}
