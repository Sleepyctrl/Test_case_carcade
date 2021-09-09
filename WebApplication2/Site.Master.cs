using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Enabled == false)
            {
                TextBox1.Enabled = true;
            }
            else TextBox1.Enabled = false;
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            string textboxfilter = "";
            bool Textfilter = false;
            if (TextBox1.Text == string.Empty)
            {
            }
            else
            {
                Textfilter = true;
                textboxfilter = TextBox1.Text;
            }
            switch (Convert.ToInt32(DropDownList1.SelectedValue))
            {
                //без сортировки
                case 0:
                    if (Textfilter == true)
                    {
                        SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                            "where Customer.CustomerName like '%" + textboxfilter + "%' or Customer.CustomerName like '" + textboxfilter + "%' ";
                    }
                    else SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                           "ORDER BY pay.PaymentDate ASC";
                    break;
                //по возрастанию
                case 1:
                    if(Textfilter==true)
                    {
                        SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                            "where Customer.CustomerName like '%" + textboxfilter + "%' or Customer.CustomerName like '" + textboxfilter + "%' " +
                            "ORDER BY pay.PaymentDate ASC";
                    }else SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                            "ORDER BY pay.PaymentDate ASC";
                    break;

                //по убыванию
                case 2:
                    if (Textfilter == true)
                    {
                        SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                            "where Customer.CustomerName like '%" + textboxfilter + "%' or Customer.CustomerName like '" + textboxfilter + "%' " +
                            "ORDER BY pay.PaymentDate DESC";
                    }
                    else SqlDataSource1.SelectCommand = "SELECT * FROM[pay]INNER JOIN[Customer] on Customer.Id = Customerid " +
                           "ORDER BY pay.PaymentDate DESC";
                    break;

                
                default:
                    break;

            }
        }
    }
}