using CarServiceRecords.Common;
using CarServiceRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Administration.Users
{
    public partial class List : System.Web.UI.Page
    {
        private static IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.ItemsList.DataSource = data.Users.All().ToList();
                this.DataBind();
            }
        }

        public void Delete_Item(object sender, CommandEventArgs e)
        {
            var item = data.Users.Find(e.CommandArgument.ToString());
            data.Users.Delete(item);
            data.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}