namespace CarServiceRecords.Application.Administration.SitePages
{
    using System;

    using CarServiceRecords.Common;
    using CarServiceRecords.Data;
    using CarServiceRecords.Models;
    
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
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                SitePage item;

                if (isNewItem)
                {
                    item = new SitePage();
                    data.SitePages.Add(item);
                    item.DateCreated = DateTime.Now;
                }
                else
                {
                    item = data.SitePages.Find(this.itemId);
                }

                item.Title = this.title.Text;
                item.Content = this.content.Text;
                item.IsVisible = this.isVisibleSelect.SelectedValue == "0" ? false : true;

                data.SaveChanges();
                Response.Redirect("List.aspx");
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (!isNewItem)
            {
                SitePage item = data.SitePages.Find(itemId);

                this.title.Text = item.Title;
                this.content.Text = item.Content;
            }
        }
        
    }
}