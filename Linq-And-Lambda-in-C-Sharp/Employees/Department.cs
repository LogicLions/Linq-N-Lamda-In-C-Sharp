namespace Linq_And_Lambda_in_C_Sharp.Employees
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; }

        public static List<Department> GetDepartmentList() 
        {
            return new List<Department>()
            {
                new Department() 
                    { 
                        Id = 1, 
                        Name = "Team Leaders",
                        employees = new List<Employee>()
                        {
                            new Employee() { Id=15, Name="Oliver", Salary = 35000},
                            new Employee() { Id=16, Name="Charles", Salary = 48000 },
                            new Employee() { Id=17, Name="Oscar", Salary = 20000 },
                            new Employee() { Id=18, Name="Anthony", Salary = 10000 },
                            new Employee() { Id=19, Name="George", Salary = 55000 },
                            new Employee() { Id=20, Name="Daniel", Salary = 20000 },
                        }
                    },
                new Department()
                    { 
                        Id = 2, 
                        Name = "Managers",
                        employees = new List<Employee>()
                        {
                            new Employee() { Id=8, Name="Matt", Salary = 30000 },
                            new Employee() { Id=9, Name="Dave", Salary = 20000 },
                            new Employee() { Id=10, Name="Steve", Salary = 65000 },
                            new Employee() { Id=11, Name="Jack", Salary = 10000 },
                        }
                    },
                new Department()
                    {
                        Id = 3,
                        Name = "HR",
                        employees = new List<Employee>()
                        {
                             new Employee() { Id=1, Name="John", Salary = 30000 },
                             new Employee() { Id=2, Name="Chris", Salary = 45000 },
                             new Employee() { Id=3, Name="Tom", Salary = 40000 },
                             new Employee() { Id=4, Name="Leo", Salary = 52000},
                             new Employee() { Id=5, Name="Albert", Salary = 25000 },
                             new Employee() { Id=6, Name="Stephen", Salary = 28000 },
                             new Employee() { Id=7, Name="Mark", Salary = 35000 },
                        }
                    }
            };
        }
    }
}
