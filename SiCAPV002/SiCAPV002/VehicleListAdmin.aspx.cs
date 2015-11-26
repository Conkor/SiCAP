using SiCAP_GrupoCARARA.App_Domain;
using SiCAP_GrupoCARARA.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiCAPV002
{
    public partial class VehicleListAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (!Page.IsPostBack)
                {

                    //Populating a DataTable from database.
                    DataTable dt = this.GetData();

                    //Building an HTML string.
                    StringBuilder html = new StringBuilder();

                    //Table start.
                    html.Append("<table border = '1'>");

                    //Building the Header row.
                    html.Append("<tr>");

                    html.Append("<th>");
                    html.Append("Numero de placa");
                    html.Append("</th>");
                    html.Append("<th>");
                    html.Append("Color");
                    html.Append("</th>");

                    html.Append("<th>");
                    html.Append("Tipo");
                    html.Append("</th>");

                    html.Append("<th>");
                    html.Append("Editar");
                    html.Append("</th>");
                    html.Append("</tr>");

                    //Building the Data rows.
                    foreach (DataRow row in dt.Rows)
                    {
                        html.Append("<tr>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            html.Append("<td>");
                            html.Append(row[column.ColumnName]);
                            html.Append("</td>");

                        }
                        html.Append("<td>");
                        html.Append("<button class = \"btn btn-success\" />");
                        html.Append("</td>");

                        html.Append("</tr>");
                    }

                    //Table end.
                    html.Append("</table>");

                    //Append the HTML string to Placeholder.
                    PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
                }
            }

        }

        private DataTable GetData()
        {
            BaseData data = new BaseData();

            using (SqlConnection con = data.ManageDatabaseConnection("Open"))
            {
                VehicleData vehicleD = new VehicleData();
                UserData user = new UserData();
                User userInSession = user.getUserInSession((string)Session["user"]); ;
                int idUser = userInSession.Id;
                using (SqlCommand cmd = new SqlCommand("SELECT NumberPlate, Color, Type FROM Vehicle where IdUser = '" + idUser + "';"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
    }
    }
