using CarServiceRecords.Common;
using CarServiceRecords.Data;
using CarServiceRecords.Models;
using ErrorHandlerControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Administration.CarModels
{
    public partial class AddEdit : System.Web.UI.Page
    {
        private bool isNewItem = false;
        private int itemId;
        private IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.itemId = Convert.ToInt32(Request.Params["itemId"]);
            isNewItem = (this.itemId == 0);

            if(!Page.IsPostBack){
                this.make.DataSource = data.CarMakes.All().ToList();
                this.make.SelectedIndex = 0;
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CarModel item;

                if (isNewItem)
                {
                    item = new CarModel();
                    data.CarModels.Add(item);
                }
                else
                {
                    item = data.CarModels.Find(this.itemId);
                }

                item.Name = this.name.Text;
                item.Make = data.CarMakes.Find(int.Parse(this.make.SelectedValue));

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

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.DataBind();

            if (!isNewItem)
            {
                CarModel item = data.CarModels.Find(itemId);

                this.make.SelectedValue = item.Make.Id.ToString();
                this.name.Text = item.Name;
            }
        }
    }
}