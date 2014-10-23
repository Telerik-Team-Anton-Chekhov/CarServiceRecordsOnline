using CarServiceRecords.Data;
using CarServiceRecords.Models;
using CarServiceRecords.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Public
{
    public partial class SearchCar : System.Web.UI.Page
    {
        private DataProvider data;
        private bool searchPerformed = false;
        private IQueryable<Car> carsFound;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.data = new DataProvider();

            if (!Page.IsPostBack)
            {
                
                this.make.DataSource = data.CarMakes.All().ToList();
                this.make.SelectedIndex = 0;
                this.model.DataSource = data.CarMakes.All().ToList()[0].Models.ToList();

                BindEnumerationToDropdownList<CarType>(this.type);
                BindEnumerationToDropdownList<EngineType>(this.engine);
                BindEnumerationToDropdownList<GearType>(this.gear);
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            //this.ItemsList.Visible = true;

            // Get Form Values
            var makeId = int.Parse(this.make.SelectedValue);
            var modelId = int.Parse(this.model.SelectedValue);
            var typeId = this.type.SelectedValue;
            var engineId = this.type.SelectedValue;
            var gearId = this.type.SelectedValue;

            this.carsFound = data.Cars.All()
                            .Where(c => c.Model.Make.Id == makeId)
                            .Where(c => c.Model.Id == modelId);

            if (typeId != "-1")
            {
                var carType = (CarType)int.Parse(typeId);
                carsFound = carsFound.Where(c => c.Type == carType);
            }

            if (engineId != "-1")
            {
                var carEngine = (EngineType)int.Parse(engineId);
                carsFound = carsFound.Where(c => c.Engine == carEngine);
            }

            if (gearId != "-1")
            {
                var carGear = (GearType)int.Parse(gearId);
                carsFound = carsFound.Where(c => c.Gear == carGear);
            }

            this.ItemsList.DataSource = carsFound.ToList();
            this.searchPerformed = true;
        }

        protected void Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.model.DataSource = data.CarMakes.All().ToList()[this.make.SelectedIndex].Models.ToList();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (searchPerformed)
            {
                this.ItemsList.DataSource = carsFound.ToList();
            }

            this.DataBind();
        }

        private void BindEnumerationToDropdownList<T>(DropDownList list)
        {
            var names = Enum.GetNames(typeof(T));
            var values = Enum.GetValues(typeof(T));

            list.Items.Add(new ListItem("Select", "-1"));

            for (int i = 0; i <= names.Length - 1; i++)
            {
                list.Items.Add(new ListItem(names[i], Convert.ToInt32(values.GetValue(i)).ToString()));
            }
        }
    }
}