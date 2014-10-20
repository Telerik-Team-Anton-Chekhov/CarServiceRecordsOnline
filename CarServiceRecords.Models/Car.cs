namespace CarServiceRecords.Models
{
    using System.Collections.Generic;

    using CarServiceRecords.Models.Enumerations;

    public class Car
    {
        private ICollection<RepairJob> repairJobs;

        public Car()
        {
            this.repairJobs = new HashSet<RepairJob>();
        }

        public int Id { get; set; }

        public string VinNumber { get; set; }

        public virtual CarModel Model { get; set; }

        public virtual CarType Type { get; set; }

        public virtual EngineType Engine { get; set; }

        public virtual GearType Gear { get; set; }

        public virtual ICollection<RepairJob> RepairJobs
        {
            get
            {
                return this.repairJobs;
            }

            set
            {
                this.repairJobs = value;
            }
        }
    }
}
