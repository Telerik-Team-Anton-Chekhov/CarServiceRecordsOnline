namespace CarServiceRecords.Models
{
    using System;

    public class SitePage
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsVisible { get; set; }
    }
}
