using SiCAP_GrupoCARARA.App_Domain;
using SiCAP_GrupoCARARA.Data;
using SiCAP_GrupoCARARA.App_Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace SiCAP_GrupoCARARA
{
    public partial class Reservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            LabelDateOfPresentDay.Text = thisDay.ToString("dd/MM/yyyy");
            populateDDLListOfParkingLots();
            
        }


        void populateDDLListOfParkingLots()
        {
            //List<Vehicle> lstVehicles = new List<Vehicle>();
            ReservationTransaction transaction = new ReservationTransaction();
            List<ParkingLot> lstParkingLots = transaction.ReadExistingParkingLots();
            DropDownListParkingLots.DataTextField = "parkingLotName";
            DropDownListParkingLots.DataValueField = "id";
            DropDownListParkingLots.DataSource = lstParkingLots;
            DropDownListParkingLots.DataBind();

        }



        protected void ButtonConfirmParkingLot_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ParkingLot_001.aspx"); 
        }

        protected void DropDownListVehiclesOfOneUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListParkingLots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}