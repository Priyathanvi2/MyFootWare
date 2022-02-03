using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyFoodWareApp.Models
{
    public class DbConn
    {
        string ConnectionString = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";
        OrderStatusProperty os = new OrderStatusProperty();
        public DataTable view(FootwareProperty fp)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter($"select ProductCode,Name,Cost from MyFootWare where Category ='{fp.Category}'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public OrderStatusProperty Fetch(FootwareProperty foot)
        {
            OrderStatusProperty ops = new OrderStatusProperty();
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter($"select * from MyFootWare where ProductCode = {foot.ProductCode} ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ops.ProductCode = Convert.ToInt32(dt.Rows[0][0]);
            ops.ProductName = dt.Rows[0][1].ToString();
            ops.Cost = Convert.ToInt32(dt.Rows[0][2]);
            return ops;
        }
        public string Payment(OrderStatusProperty osp)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into MyFootWareOrder values({osp.ProductCode},'{osp.ProductName}',{osp.Cost},{osp.Quantity},{osp.Total})",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Insert Successfully";
        }
        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter($"select * from MyFootWareOrder", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}