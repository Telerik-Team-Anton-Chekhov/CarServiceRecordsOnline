namespace CarServiceRecords.Models
{
    public class CarService
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual User Owner { get; set; }

        public virtual Town Town { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
