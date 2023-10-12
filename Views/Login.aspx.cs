using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetShop.Model;
using System.Data.SqlClient;
using PetShop.Repository;

namespace PetShop.Views
{
    public partial class Login : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDBFilename=C:\\Users\\timot\\OneDrive\\Documents\\PetShop\\App_Data\\Petshop.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        LoginRepository cusrepo = new LoginRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            Customer customer = cusrepo.login(email, password);

            if (IsValidUser(email,password))
            {
                if (rememberChk.Checked)
                {
                    HttpCookie rememberMeCookie = new HttpCookie("RememberMe");
                    rememberMeCookie.Value = customer.CustomerId.ToString();
                    rememberMeCookie.Expires = DateTime.Now.AddMinutes(30);
                    Response.Cookies.Add(rememberMeCookie);
                }
                Response.Redirect("Home.aspx");
            }
            else if(email == "" ||  password == "")
            {
                errorLbl.Text = "Email and password cannot be empty";
            }
            else
            {
                errorLbl.Text = "Invalid Email or Password";
            }
        }
        private bool IsValidUser(string email, string password)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Customer WHERE CustomerEmail=@CustomerEmail AND CustomerPassword=@Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerEmail", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                
                if(count == 1)
                {
                    isValid = true;
                    query = "SELECT CustomerRole FROM Customer WHERE CustomerEmail=@CustomerEmail";
                    command.CommandText = query;
                    string role = (string)command.ExecuteScalar();
                    Session["CustomerRole"] = role;
                    Session["CustomerEmail"] = email;
                }
                connection.Close();
            }
            return isValid;
        }

        protected void rememberChk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}