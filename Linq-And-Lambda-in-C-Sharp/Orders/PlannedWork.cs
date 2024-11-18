namespace Linq_And_Lambda_in_C_Sharp.Orders
{
    internal class PlannedWork
    {
        public int WorkOrderNumber { get; set; }

        public DateTime? ScheduledDate { get; set; }

        public static List<PlannedWork> GetPlannedWorkList() 
        {
            return new List<PlannedWork> 
            {
                new PlannedWork {  WorkOrderNumber = 1, ScheduledDate = DateTime.Now.AddDays(2) } ,
                new PlannedWork {  WorkOrderNumber = 2, ScheduledDate = DateTime.Now.AddDays(4) } ,
                new PlannedWork {  WorkOrderNumber = 4, ScheduledDate = DateTime.Now.AddDays(8) } ,
            };
        }
    }
}
