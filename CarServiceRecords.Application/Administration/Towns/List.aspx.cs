namespace CarServiceRecords.Application.Administration.Towns
{
    using CarServiceRecords.Common;
    using CarServiceRecords.Data;
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;
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
                this.ItemsList.DataSource = data.Town.All().ToList();
                this.DataBind();
            }
        }
        public void Delete_Item(object sender, CommandEventArgs e)
        {
            var itemId = int.Parse(e.CommandArgument.ToString());
            var item = data.Town.Find(itemId);
            data.Town.Delete(item);
            data.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }
    }
}