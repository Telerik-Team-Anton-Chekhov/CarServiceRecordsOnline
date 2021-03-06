﻿using CarServiceRecords.Common;
using CarServiceRecords.Data;
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
    public partial class ViewService : System.Web.UI.Page
    {
        private static IDataProvider data;

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            var currentUserId = User.Identity.GetUserId();
            this.ServiceList.DataSource = data.CarServices.All().Where(s => s.Owner.Id == currentUserId).ToList();
            this.DataBind();
        }
    }
}