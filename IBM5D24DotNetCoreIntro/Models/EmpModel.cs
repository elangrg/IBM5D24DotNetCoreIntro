namespace IBM5D24DotNetCoreIntro.Models
{
    public class Employee
    {
  
        public int EmployeeID { get; set; } = 0;
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; }=string.Empty;


    }


    public class EmployeeContext
    {
        static List<Employee> _employees ;

        static  EmployeeContext()
        {
            _employees = new List<Employee> { new Employee { EmployeeID=1000, FirstName="Ganesh", LastName="Mahesh" } };
        }

        public Employee GetEmployeeByID(int id) => _employees.SingleOrDefault(e=>e.EmployeeID==id);

        public IEnumerable<Employee> GetEmployees() => _employees;

    }


}
