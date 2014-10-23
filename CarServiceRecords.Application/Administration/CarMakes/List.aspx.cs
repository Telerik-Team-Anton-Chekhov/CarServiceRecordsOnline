using CarServiceRecords.Common;
using CarServiceRecords.Data;
using CarServiceRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace CarServiceRecords.Application.Administration.CarMakes
{
    public partial class List : System.Web.UI.Page
    {
        private static IDataProvider data;

        public IQueryable<CarMake> GetItems()
        {
            return data.CarMakes.All().OrderBy(x => x.Id).Include("Models");
            // MultipleActiveResultSets=True;
        }

        protected void Delete_Item(object sender, CommandEventArgs e)
        {
            var itemId = int.Parse(e.CommandArgument.ToString());
            var item = data.CarMakes.Find(itemId);
            data.CarMakes.Delete(item);
            data.SaveChanges();
            Response.Redirect(Request.RawUrl);
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            data = new DataProvider();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ShowPager();
        }

        private void ShowPager()
        {
            DataPager pager = (DataPager)ItemsList.FindControl("ItemsPager");
            pager.Visible = (pager.PageSize < pager.TotalRowCount);
        }
    }
}