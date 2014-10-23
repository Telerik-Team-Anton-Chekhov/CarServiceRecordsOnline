using CarServiceRecords.Common;
using CarServiceRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Public
{
    public partial class CarDetails : System.Web.UI.Page
    {
        private static IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var itemId = Convert.ToInt32(Request.Params["itemId"]);
            if (itemId == 0)
            {
                Response.Redirect("SearchCar.aspx");
            }

            this.CarList.DataSource = data.Cars.All().Where(s => s.Id == itemId).ToList();
            this.RepairsList.DataSource = data.RepairJobs.All().Where(x => x.Car.Id == itemId).ToList();
            this.DataBind();
        }
    }
}