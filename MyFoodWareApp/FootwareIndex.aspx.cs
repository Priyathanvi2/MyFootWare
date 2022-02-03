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
    public partial class FootwareIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnview_Click(object sender, EventArgs e)
        {
            FootwareProperty fp = new FootwareProperty();
            DbConn db = new DbConn();
            fp.Category = Convert.ToString(Categorydd.SelectedValue);
            DataTable dt = new DataTable();
            dt = db.view(fp);
            GView.DataSource = dt;
            GView.DataBind();
            div1.Visible = true;
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session["value"] = txtCode.Text;
            Response.Redirect("OrderHere.aspx");
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {           
            Response.Redirect("Status.aspx");
        }
    }
}