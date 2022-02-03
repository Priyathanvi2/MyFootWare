using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyFoodWareApp.Models;

namespace MyFoodWareApp
{
    public partial class OrderHere : System.Web.UI.Page
    {
        FootwareProperty fp = new FootwareProperty();
        DbConn con = new DbConn();
        protected void Page_Load(object sender, EventArgs e)
        {
            DbConn con = new DbConn();

            if(!IsPostBack)
            {
                lblcode.Text = "" + Session["value"];
                fp.ProductCode = Convert.ToInt32(Session["value"]);
                OrderStatusProperty osp = con.Fetch(fp);
            
            lblname.Text = osp.ProductName;
            lblprice.Text = osp.ToString();
            }
        }

        protected void btnbil_Click(object sender, EventArgs e)
        {
            fp.ProductCode  = Convert.ToInt32(Session["value"]);
            OrderStatusProperty osp = con.Fetch(fp);
            int Quantity = Convert.ToInt32(txtquantity.Text);
            lbltotal.Text = Convert.ToString(osp.Cost * Quantity);

        }

        protected void btnToalPayment_Click(object sender, EventArgs e)
        {
            OrderStatusProperty status = new OrderStatusProperty();
            status.ProductCode = Convert.ToInt32(lblcode.Text);
            status.ProductName = lblname.Text;
            status.Cost = Convert.ToInt32(lblcode.Text);
            status.Quantity = Convert.ToInt32(txtquantity.Text);
            status.Total = Convert.ToInt32(lbltotal.Text);
            string msg = con.Payment(status);
            Response.Write($"<script>alert('{msg}')</script>");
        }
    }
}