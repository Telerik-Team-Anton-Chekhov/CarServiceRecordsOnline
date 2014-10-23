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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace CarServiceRecords.Application.Public
{
    public partial class EditService : System.Web.UI.Page
    {
        private bool isNewItem = false;
        private string currentUserId;
        private int itemId;
        private IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
            currentUserId = User.Identity.GetUserId();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var currentUserService = data.CarServices.All().Where(x => x.Owner.Id == currentUserId).FirstOrDefault();

            if (currentUserService != null)
	        {
                this.itemId = currentUserService.Id;
	        }
            else
            {
                isNewItem = true;
            }
            
            if (!Page.IsPostBack)
            {
                this.Town.DataSource = data.Town.All().ToList();
                this.Town.SelectedIndex = 0;
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CarService item;

                if (isNewItem)
                {
                    item = new CarService();
                    data.CarServices.Add(item);
                }
                else
                {
                    item = data.CarServices.Find(this.itemId);
                }

                item.Name = this.Name.Text;
                item.Town = data.Town.Find(int.Parse(this.Town.SelectedValue));
                item.Address = this.Address.Text;
                item.Phone = this.Phone.Text;
                item.Owner = data.Users.Find(currentUserId);

                try
                {
                    data.SaveChanges();
                    Response.Redirect("ViewService.aspx", false);
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
                CarService item = data.CarServices.Find(itemId);

                this.Town.SelectedValue = item.Town.Id.ToString();
                this.Name.Text = item.Name;
                this.Phone.Text = item.Phone;
                this.Address.Text = item.Address;
            }
        }
    }
}