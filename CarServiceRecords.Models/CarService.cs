namespace CarServiceRecords.Models
{
    using System.Collections.Generic;

    public class CarService
    {
        private ICollection<ServiceComments> comments;

        public CarService()
        {
            this.comments = new HashSet<ServiceComments>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual User Owner { get; set; }

        public virtual Town Town { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool IsVip { get; set; }

        public virtual ICollection<ServiceComments> Comments { get; set; }
    }
}
