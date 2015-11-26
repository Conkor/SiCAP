using SiCAP_GrupoCARARA.App_Domain;
using SiCAP_GrupoCARARA.Data;
using SiCAPV002.App_Domain;
using SiCAPV002.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiCAPV002
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateDropDownListMajor();
            PopulateDropDownListUserType();
            this.btnAdd.ServerClick += btnAddUser_Click;
            
        }

        public void PopulateDropDownListMajor()
        {
            MajorData data = new MajorData();
            List<Major> majors = data.Majors();
            ddlMajor.DataTextField = "mainMajor";
            ddlMajor.DataValueField = "idMajor";
            ddlMajor.DataSource = majors;
            ddlMajor.DataBind();

        }

        public void PopulateDropDownListUserType()
        {
            UserTypeData data = new UserTypeData();
            List<UserTypes> type = data.Types();
            ddlUserType.DataTextField = "UserType";
            ddlUserType.DataValueField = "IdUserType";
            ddlUserType.DataSource = type;
            ddlUserType.DataBind();

        }
        //Corregir dropdownlist
        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            UserData data = new UserData();
            int idNumberC = Convert.ToInt32(idNumer.Text);
            int major = Convert.ToInt32(ddlMajor.SelectedItem.Value);
            int type = Convert.ToInt32(ddlUserType.SelectedItem.Value);
            User user = new User(email.Text, idNumberC, name.Text, secondName.Text, lastname.Text, secondLastname.Text, cellphone.Text, idNumer.Text, major, type, false, false);
            data.createUser(user);
            email.Text = String.Empty;
            name.Text = String.Empty;
            secondName.Text = String.Empty;
            lastname.Text = String.Empty;
            secondLastname.Text = String.Empty;
            cellphone.Text = String.Empty;
            idNumer.Text = String.Empty;
            ddlMajor.SelectedIndex = -1;
            ddlUserType.SelectedIndex = -1;

        }
        
    }
}