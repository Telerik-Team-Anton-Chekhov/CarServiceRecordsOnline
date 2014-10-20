namespace CarServiceRecords.Models
{
    using System.Collections.Generic;

    public class CarMake
    {
        private ICollection<CarModel> models;

        public CarMake()
        {
            this.models = new HashSet<CarModel>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<CarModel> Models 
        { 
            get
            {
                return this.models;
            }

            set
            {
                this.models = value;
            }
        }
    }
}
