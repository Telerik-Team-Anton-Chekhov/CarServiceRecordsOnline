using CarServiceRecords.Common;
using CarServiceRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarServiceRecords.Application.Administration.SitePages
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
                this.ItemsList.DataSource = data.SitePages.All().ToList();
                this.ItemsList.DataBind();
            }
        }

        public void Delete_Item(object sender, CommandEventArgs e)
        {
            var itemId = int.Parse(e.CommandArgument.ToString());
            var item = data.SitePages.Find(itemId);
            data.SitePages.Delete(item);
            data.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}