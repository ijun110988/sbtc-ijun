namespace EmployeeMVC.Models
{
    public class Employee
    {
        public string emp_cd { get; set; } = string.Empty;
        public string fullname { get; set; } = string.Empty;
        public DateTime? birth_dt { get; set; }
        public string? birth_place { get; set; }
        public decimal? last_salary { get; set; }
        public int? number_of_sibling { get; set; }
        public bool? isactive { get; set; }
    }
}
