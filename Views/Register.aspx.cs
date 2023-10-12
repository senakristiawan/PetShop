using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetShop.Controller;

namespace PetShop.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            CustomerController control = new CustomerController();
            string name = nameTxt.Text;
            string email = emailTxt.Text;
            string password = passTxt.Text;
            string gender = genderRadio.SelectedValue;
            string address = addressTxt.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(address))
            {
                errorLbl.Text = "All fields are required";
            }
            else
            {
                try
                {
                    control.Validate(name, email, password, gender, address);
                    Response.Redirect("Login.aspx");
                }
                catch (Exception ex)
                {
                    errorLbl.Text = ex.Message;
                }
            }
        }
    }
}