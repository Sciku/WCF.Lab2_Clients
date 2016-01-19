using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF.Lab2_WebFormClientBMI
{
    public partial class BMI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BMIClient host = new BMIClient();

            Label1.Text = host.BMI(Convert.ToDecimal(TextBox1.Text),Convert.ToDecimal(TextBox2.Text)).ToString();
        }
    }
}