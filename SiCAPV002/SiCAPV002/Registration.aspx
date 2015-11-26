<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMenu.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="SiCAPV002.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/login.css" rel="stylesheet" />

    <legend><h1>Registro</h1></legend>
    <br />
    <table class="table">
        <thead>
            <th style="width: 338px"></th>
        <th></th>
        </thead>
        <tbody>
            <tr>
                <form id="frm" runat="server">
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Nombre</td>
                <td style="border: hidden">
               <asp:TextBox ID="name" runat="server" CssClass="textbox" Width="308px"></asp:TextBox>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Sedundo nombre</td>
               <td style="border: hidden"><asp:TextBox ID="secondName" runat="server" CssClass="textbox" Width="306px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Apellido</td>
             <td style="border: hidden"><asp:TextBox ID="lastname" runat="server" CssClass="textbox" Width="306px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Segundo Apellido</td>
              <td style="border: hidden"><asp:TextBox ID="secondLastname" runat="server" CssClass="textbox" Width="305px" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Numero de carnet o cedula</td>
              <td style="border: hidden"><asp:TextBox ID="idNumer" runat="server"  CssClass="textbox" Width="305px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Correo</td>
              <td style="border: hidden"><asp:TextBox ID="email" runat="server" CssClass="textbox" Width="304px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Celular</td>
              <td style="border: hidden"><asp:TextBox ID="cellphone" runat="server" CssClass="textbox" Width="301px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Carrera</td>
              <td><asp:DropDownList ID="ddlMajor" runat="server" OnLoad="Page_Load" ></asp:DropDownList></td>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;">Posicion</td>
              <td style="border: hidden"><asp:DropDownList ID="ddlUserType" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td style="border-style: hidden; border-color: inherit; border-width: medium; width: 338px;"></td>
              <td style="border: hidden"><input type="button" id="btnAdd" runat="server"  value= "Registrar" class="btn btn-success"/></td>
                                          
                 </tr>
            </form>
        </tbody>
    </table>

</asp:Content>
