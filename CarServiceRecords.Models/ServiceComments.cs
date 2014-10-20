namespace CarServiceRecords.Models
{
    using System;

    public class ServiceComments
    {
        public int Id { get; set; }

        public virtual User Creator { get; set; }

        public string Content { get; set; }

        public virtual CarService CarService { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
