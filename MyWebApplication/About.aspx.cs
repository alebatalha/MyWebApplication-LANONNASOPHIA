using System;
using System.Web.UI;

namespace MyWebApplication
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome");
        }
    }
}