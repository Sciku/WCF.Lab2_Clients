using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF.Lab2_WebFormClientHobby
{
    public partial class Hobby : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HobbyClient host = new HobbyClient();
            Label1.Text = host.WorstMovieTitle(TextBox1.Text);
        }
    }
}