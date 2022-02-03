using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyFoodWareApp.Models;

namespace MyFoodWareApp
{
    public partial class Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConn con = new DbConn();
            DataTable dt = new DataTable();
            dt = con.Status();
            GStatus.DataSource = dt;
            GStatus.DataBind();
        }
    }
}