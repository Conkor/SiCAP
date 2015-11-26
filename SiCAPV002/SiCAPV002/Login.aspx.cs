using SiCAP_GrupoCARARA.App_Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SiCAP_GrupoCARARA.Data;
using SiCAP_GrupoCARARA.App_Domain;

namespace SiCAPV002
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnLogi.ServerClick += btnLogin_Click;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String email = Email.Text;
            String password = Password.Text;
            LoginTransaction singin = new LoginTransaction(email, password);
            String login = singin.executeLoginTransaction();
            LblLogin.Text = login;

            UserData user = new UserData();
            User userInSession = user.getUserInSession("email");
            userInSession = user.getUserInSession((string)Session["user"]);

            if ((login.Equals("")) && (userInSession.Type == 4)) {

                    Response.Redirect("http://localhost:62673/IndezSecurity.aspx");
                
            }
            if ((login.Equals("")) && (userInSession.Type == 2))
            {

                Response.Redirect("http://localhost:62673/IndezSecurity.aspx");

            }
            if ((login.Equals("")) && (userInSession.Type == 1))
            {

                Response.Redirect("http://localhost:62673/IndezSecurity.aspx");

            }
        }
    }
}