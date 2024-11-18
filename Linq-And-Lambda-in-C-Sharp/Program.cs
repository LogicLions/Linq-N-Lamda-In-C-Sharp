namespace Linq_And_Lambda_in_C_Sharp
{
    using System.Linq;
    using Linq_And_Lambda_in_C_Sharp.Orders;

    internal class Program
    {
        static void Main(string[] args)
        {
            GetDescriptionByPlannedWork();
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
                             order.WorkDescription
                         };

            foreach ( var item in result ) 
            {
                Console.WriteLine(item.WorkDescription);
            }
        }
    }
}
