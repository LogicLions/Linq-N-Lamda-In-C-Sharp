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
            Console.WriteLine("----Find Employees having more than 50k salary and belongs to department having more than 5 employees----");
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
            Console.WriteLine("-------------------------------------------------------------------");
        }

        //(Linq) input - list of planned work , output - find description of work
        public static void GetDescriptionByPlannedWork()
        {
            Console.WriteLine("----Having PlannedWork list, need to find their work descriptions in work order list-----");
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
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}
