using CarServiceRecords.Data;
using CarServiceRecords.Models;
using CarServiceRecords.Models.Enumerations;
using ErrorHandlerControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Administration.Cars
{
    public partial class AddEdit : System.Web.UI.Page
    {
        private DataProvider data;
        private bool isNewItem = false;
        private int itemId;

        protected void Page_Init(object sender, EventArgs e)
        {
            this.data = new DataProvider();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.itemId = Convert.ToInt32(Request.Params["itemId"]);
            isNewItem = (this.itemId == 0);

            if (!this.IsPostBack)
            {
                this.make.DataSource = data.CarMakes.All().ToList();
                this.make.SelectedIndex = 0;
                this.model.DataSource = data.CarMakes.All().ToList()[0].Models.ToList();

                BindEnumerationToDropdownList<CarType>(this.type);
                BindEnumerationToDropdownList<EngineType>(this.engine);
                BindEnumerationToDropdownList<GearType>(this.gear);
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Car item;

                if (isNewItem)
                {
                    item = new Car();
                    data.Cars.Add(item);
                }
                else
                {
                    item = data.Cars.Find(this.itemId);
                }

                item.VinNumber = this.vinNumber.Text;
                item.Model = data.CarModels.Find(int.Parse(this.model.SelectedValue));
                item.Engine = (EngineType)int.Parse(this.engine.SelectedValue);
                item.Gear = (GearType)int.Parse(this.gear.SelectedValue);
                item.Type = (CarType)int.Parse(this.type.SelectedValue);

                try
                {
                    data.SaveChanges();
                    Response.Redirect("List.aspx", false);
                }
                catch (Exception ex)
                {
                    ErrorSuccessNotifier.AddErrorMessage(ex);
                }

            }
        }

        protected void Make_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.model.DataSource = data.CarMakes.All().ToList()[this.make.SelectedIndex].Models.ToList();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();

            if (!isNewItem)
            {
                Car item = data.Cars.Find(itemId);

                this.vinNumber.Text = item.VinNumber;

                this.make.SelectedValue = item.Model.Make.Id.ToString();

                this.model.DataSource = data.CarMakes.Find(item.Model.Make.Id).Models.ToList();
                this.model.DataBind();

                this.model.SelectedValue = item.Model.Id.ToString();

                this.type.SelectedValue = ((int)item.Type).ToString();
                this.engine.SelectedValue = ((int)item.Engine).ToString();
                this.gear.SelectedValue = ((int)item.Gear).ToString();
            }
        }

        private void BindEnumerationToDropdownList<T>(DropDownList list)
        {
            var names = Enum.GetNames(typeof(T));
            var values = Enum.GetValues(typeof(T));

            for (int i = 0; i <= names.Length - 1; i++)
            {
                list.Items.Add(new ListItem(names[i], Convert.ToInt32(values.GetValue(i)).ToString()));
            }
        }
    }
}