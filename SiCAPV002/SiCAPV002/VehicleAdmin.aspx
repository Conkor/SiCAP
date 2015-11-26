<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMenu.Master" AutoEventWireup="true" CodeBehind="VehicleAdmin.aspx.cs" Inherits="SiCAPV002.VehicleAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

       <link href="css/login.css" rel="stylesheet" />
<!-- Form Name -->
<legend>
    <h1>Vehículo</h1></legend>

<table class="table">
        <thead>
            <th style="width: 338px"></th>
        <th></th>
        </thead>
        <tbody>
        <form id="frm" runat="server">
            <tr>
                
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Numero de placa</td>
              <td style="border: hidden"><asp:TextBox ID="plate" runat="server" CssClass="textbox" Width="297px" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Color</td>
              <td style="border: hidden"><asp:TextBox ID="color" runat="server"  CssClass="textbox" Width="299px"></asp:TextBox></td>
            </tr>
           <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Tipo de vehículo</td>
              <td><asp:DropDownList ID="ddlType" runat="server">
                  <asp:ListItem>Motocicleta</asp:ListItem>
                  <asp:ListItem>Automóvil</asp:ListItem>
                  </asp:DropDownList></td>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;"></td>
              <td style="border: hidden"><input type="button" id="btnAdd" runat="server"  value= "Registrar" class="btn btn-success"/></td>
                                          
                 </tr>
            </form>
        </tbody>
    </table>




</asp:Content>
