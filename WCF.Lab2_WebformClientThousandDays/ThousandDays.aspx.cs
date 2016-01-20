using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF.Lab2_WebformClientThousandDays
{
    public partial class ThousandDays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ThousandDaysClient host = new ThousandDaysClient();
            Label1.Text = host.days(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text)).ToString() + " dagar kvar till du fyller jämt antal 1000 år";

        }
    }
}