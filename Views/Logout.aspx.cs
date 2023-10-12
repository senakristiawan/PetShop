using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetShop.Views
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            HttpCookie removeCookie = new HttpCookie("removeCookie");
            removeCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(removeCookie);

            Response.Redirect("Login.aspx");
        }
    }
}