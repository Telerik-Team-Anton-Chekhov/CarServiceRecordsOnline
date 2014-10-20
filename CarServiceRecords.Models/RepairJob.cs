namespace CarServiceRecords.Models
{
    using System;

    public class RepairJob
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual CarService CarService { get; set; }

        public virtual Car Car { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
