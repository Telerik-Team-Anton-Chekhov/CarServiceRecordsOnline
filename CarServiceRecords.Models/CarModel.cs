﻿namespace CarServiceRecords.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual CarMake Make { get; set; }
    }
}
