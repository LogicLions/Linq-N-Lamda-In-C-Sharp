namespace Linq_And_Lambda_in_C_Sharp
{
    using System.Linq;
    using Linq_And_Lambda_in_C_Sharp.Orders;
    using System;
    using Linq_And_Lambda_in_C_Sharp.Employees;

    internal class Program
    {
        static void Main(string[] args)
        {
            GetDescriptionByPlannedWork();
            GetEmployeeNamesHavingMoreThanFiftySalAndBelongsToDeptHavingMoreThanFiveEmp();
        }

        //  Find Employee names having salary more than 50k and should be belonging to department having more than 5 employees
        public static void GetEmployeeNamesHavingMoreThanFiftySalAndBelongsToDeptHavingMoreThanFiveEmp()
        {
            var departments = Department.GetDepartmentList();

            var result = departments
                            .Where(d => d.employees.Count > 5)
                            .SelectMany(d => d.employees)
                            .Where(e => e.Salary > 50000)
                            .ToList();

            foreach (var item in result)
            {
                Console.WriteLine($"Id={item.Id}, Name={item.Name}, Salary={item.Salary}");
            }
        }

        //(Linq) input - list of planned work , output - find description of work
        public static void GetDescriptionByPlannedWork()
        {
            var plans = PlannedWork.GetPlannedWorkList();
            var orders = WorkOrder.GetWorkOrdersList();

            var result = from order in orders
                         join plan in plans
                            on order.WorkOrderNumber equals plan.WorkOrderNumber
                         select new
                         {
                             order.WorkOrderNumber,
                             order.WorkDescription,
                             plan.ScheduledDate,
                         };

            foreach ( var item in result ) 
            {
                Console.WriteLine($"WorkOrderNumber:{item.WorkDescription}, WorkDescription:{item.WorkDescription}, ScheduledDate:{item.ScheduledDate}");
            }
        }
    }
}
