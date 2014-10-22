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

namespace CarServiceRecords.Application.Administration.Towns
{
    public partial class AddEdit1 : System.Web.UI.Page
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
                Town item;

                if (isNewItem)
                {
                    item = new Town();
                    data.Town.Add(item);
                }
                else
                {
                    item = data.Town.Find(this.itemId);
                }

                item.Name = this.name.Text;
               
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
                Town item = data.Town.Find(itemId);

                this.name.Text = item.Name;
            }
        }


    }
}