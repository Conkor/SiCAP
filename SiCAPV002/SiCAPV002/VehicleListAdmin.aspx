<%@ Page Title="" Language="C#" MasterPageFile="~/SecurityMenu.Master" AutoEventWireup="true" CodeBehind="VehicleListAdmin.aspx.cs" Inherits="SiCAPV002.VehicleListAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
   <style type="text/css">  
    body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        table
        {

            font-family:Arial, Helvetica, sans-serif;
            font-size:medium;
            width: 500px;
            height: 100px;
            margin-top: 30px;
            margin-left: 80px;
            border:hidden;
            border-collapse:collapse;
            resize:horizontal;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border-color: #ccc;
        }
    </style>
        </form>
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>
