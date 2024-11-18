namespace Linq_And_Lambda_in_C_Sharp.Orders
{
    internal class WorkOrder
    {
        public int WorkOrderNumber { get; set; }

        public string WorkDescription { get; set; }

        public static List<WorkOrder> GetWorkOrdersList()
        {
            return new List<WorkOrder>
            {
                new WorkOrder { WorkOrderNumber = 1, WorkDescription = "WorkDescription1" },
                new WorkOrder { WorkOrderNumber = 2, WorkDescription = "WorkDescription2" },
                new WorkOrder { WorkOrderNumber = 3, WorkDescription = "WorkDescription3" },
                new WorkOrder { WorkOrderNumber = 4, WorkDescription = "WorkDescription4" },
            };
        }
    }
}
