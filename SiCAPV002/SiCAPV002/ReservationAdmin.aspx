<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMenu.Master" AutoEventWireup="true" CodeBehind="ReservationAdmin.aspx.cs" Inherits="SiCAPV002.ReservationAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">

        <header>
		
				<div class="container">
					<h1 style="width: 1013px">&nbsp;</h1>
                    <h1 style="width: 932px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; RESERVACIONES&nbsp; paso 1: escoger parqueo</h1>
                    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fecha:
                        <asp:Label ID="LabelDateOfPresentDay" runat="server"></asp:Label>
                    </p>
                    <p>
                        ......................Paso 1:&nbsp;&nbsp;&nbsp; Escoger el parqueo</p>
                    <p>
                        &nbsp;</p>
    
            <table style="width:80%;">
                <tr>
                    <td class="auto-style3">Escoja el parqueo</td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownListParkingLots" runat="server" Height="16px" OnSelectedIndexChanged="DropDownListParkingLots_SelectedIndexChanged" Width="246px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="ButtonConfirmParkingLot" runat="server" BackColor="#006600" ForeColor="White" Height="45px" OnClick="ButtonConfirmParkingLot_Click" Text="Confirme su escogencia de parqueo" Width="244px" />
                    </td>
                </tr>

                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">

                    </td>
                </tr>


                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        
                    </td>
                </tr>

                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style4">
                        
                        &nbsp;</td>
                </tr>
                
                </table>



				</div>
		</header>


        <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
            </p>


    </form>





</asp:Content>
