using SiCAP_GrupoCARARA.App_Domain;
using SiCAP_GrupoCARARA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiCAPV002
{
    public partial class VehicleAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnAdd.ServerClick += btnAddCar_Click;

        }

        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            
            
            VehicleData vehicleD = new VehicleData();
            UserData user = new UserData();
            User userInSession = user.getUserInSession("email");
            userInSession = user.getUserInSession((string)Session["user"]);
            int idUser = userInSession.Id;
            bool isActive = true;
            string type = ddlType.SelectedItem.Value;
            SiCAP_GrupoCARARA.App_Domain.Vehicle car = new SiCAP_GrupoCARARA.App_Domain.Vehicle(plate.Text, idUser, color.Text, type , false, isActive);
            vehicleD.InsertVehicle(car);
            plate.Text = string.Empty; 
            color.Text = string.Empty;
            ddlType.SelectedIndex = -1;

        }
    }
}