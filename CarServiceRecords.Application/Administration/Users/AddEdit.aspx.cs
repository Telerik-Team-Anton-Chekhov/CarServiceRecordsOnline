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

namespace CarServiceRecords.Application.Administration.Users
{
    public partial class AddEdit : System.Web.UI.Page
    {
        private bool isNewItem = false;
        private string itemId;
        private IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.itemId = Request.Params["itemId"];
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                User item;

                if (isNewItem)
                {
                    item = new User();
                    data.Users.Add(item);
                }
                else
                {
                    item = data.Users.Find(this.itemId);
                }

                item.UserName = this.username.Text;
                item.Email = this.email.Text;

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
            if (!isNewItem)
            {
                User item = data.Users.Find(itemId);

                this.email.Text = item.Email;
                this.username.Text = item.UserName;
            }
        }
    }
}