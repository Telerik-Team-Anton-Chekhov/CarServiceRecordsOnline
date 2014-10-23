using CarServiceRecords.Common;
using CarServiceRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using CarServiceRecords.Models;
using ErrorHandlerControl;

namespace CarServiceRecords.Application.Public
{
    public partial class AddJob : System.Web.UI.Page
    {
        private string currentUserId;
        private int itemId;
        private IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
            currentUserId = User.Identity.GetUserId();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var item = new RepairJob();
                data.RepairJobs.Add(item);

                item.DateCreated = DateTime.Now;
                item.Description = this.Description.Text;
                item.CarService = data.CarServices.All().Where(x => x.Owner.Id == currentUserId).FirstOrDefault();

                var currentCar = data.Cars.All().Where(c => c.VinNumber == this.vinNumber.Text).FirstOrDefault();

                if (currentCar == null)
                {
                    currentCar = new Car();
                    currentCar.VinNumber = this.vinNumber.Text;
                    data.Cars.Add(currentCar);
                }

                item.Car = currentCar;
                

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
    }
}