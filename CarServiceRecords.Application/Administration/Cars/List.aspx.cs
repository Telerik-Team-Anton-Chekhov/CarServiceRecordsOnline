using CarServiceRecords.Common;
using CarServiceRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Administration.Cars
{
    public partial class List : System.Web.UI.Page
    {
        private static IDataProvider data;
        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
                this.ItemsList.DataSource = data.Cars.All().ToList();
                this.DataBind();
        }
    }
}