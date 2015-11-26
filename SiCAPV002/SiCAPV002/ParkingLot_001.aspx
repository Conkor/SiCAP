<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParkingLot_001.aspx.cs" Inherits="SiCAP_GrupoCARARA.ParkingLot_001" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #006600;
        }
        .auto-style3 {
            height: 26px;
            width: 60px;
        }
        .auto-style5 {
            width: 60px;
            height: 23px;
        }
        .auto-style6 {
            width: 509px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong>&nbsp;Parqueo de las Banderas</strong></span></div>
        <p style="width: 923px">
            <asp:Button ID="Eliminate_ParkingSpace" runat="server" BackColor="#CC0000" ForeColor="White" Height="33px" Text="Eliminar" Width="89px" OnClick="Eliminate_ParkingSpace_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Add_ParkingSpace" runat="server" BackColor="#009933" BorderColor="#33CC33" ForeColor="White" Height="33px" Text="Agregar" Width="102px" OnClick="Add_ParkingSpace_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LabelSpaceNumber" runat="server" style="font-size: large" Text="Inserte id del espacio nuevo" Visible="False"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxSpaceIdentifier" runat="server" Width="116px" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonInsertNewSpace" runat="server" BackColor="#006600" ForeColor="White" Height="33px" OnClick="ButtonInsertNewSpace_Click" Text="Crear nuevo espacio" Visible="False" Width="167px" />
        </p>
        <p style="width: 923px">
            <asp:Button ID="ButtonGoToReservation" runat="server" BackColor="#663300" Height="25px" OnClick="ButtonGoToReservation_Click" Text="Ir a reservación" Width="216px" ForeColor="White" />
&nbsp;
            <asp:Button ID="ButtonShowState" runat="server" BackColor="Yellow" OnClick="ButtonShowState_Click" Text="Revisar estado para horas indicadas" Visible="False" Width="237px" />
        </p>
    
            <table style="width:96%;">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="LabelVehicle" runat="server" Text="Escoger vehículo" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="DropDownListVehiclesOfOneUser" runat="server" OnSelectedIndexChanged="DropDownListVehiclesOfOneUser_SelectedIndexChanged" Width="219px" Height="28px" Visible="False">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="LabelTime" runat="server" Text="Horas de parqueo" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style1">
            <asp:Label ID="LabelFrom" runat="server" Text="Desde" Visible="False"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownListCheckIn" runat="server" Visible="False" OnSelectedIndexChanged="DropDownListCheckIn_SelectedIndexChanged">
                <asp:ListItem Value="1">6:00am-6:50am</asp:ListItem>
                <asp:ListItem Value="2">7:00am-7:50am</asp:ListItem>
                <asp:ListItem Value="3">8:00am-8:50am</asp:ListItem>
                <asp:ListItem Value="4">9:00am-9:50:am</asp:ListItem>
                <asp:ListItem Value="5">10:00am-10:50am</asp:ListItem>
                <asp:ListItem Value="6">11:00am-11:50am</asp:ListItem>
                <asp:ListItem Value="7">12:00pm-12-50pm</asp:ListItem>
                <asp:ListItem Value="8">1:00pm-1:50pm</asp:ListItem>
                <asp:ListItem Value="9">2:00pm-2:50pm</asp:ListItem>
                <asp:ListItem Value="10">3:00pm-3:50pm</asp:ListItem>
                <asp:ListItem Value="11">4:00pm-4:50pm</asp:ListItem>
                <asp:ListItem Value="12">5:00pm-5:50pm</asp:ListItem>
                <asp:ListItem Value="13">6:00pm-6:50pm</asp:ListItem>
                <asp:ListItem Value="14">7:00pm-7:50pm</asp:ListItem>
                <asp:ListItem Value="15">8:00pm-8:50pm</asp:ListItem>
                <asp:ListItem Value="16">9:00pm-9:50pm</asp:ListItem>
            </asp:DropDownList>
                        &nbsp;
            <asp:Label ID="LabelTo" runat="server" Text="Hasta" Visible="False"></asp:Label>
&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListCheckOut" runat="server" Visible="False" OnSelectedIndexChanged="DropDownListCheckOut_SelectedIndexChanged">
                <asp:ListItem Value="1">6:00am-6:50am</asp:ListItem>
                <asp:ListItem Value="2">7:00am-7:50am</asp:ListItem>
                <asp:ListItem Value="3">8:00am-8:50am</asp:ListItem>
                <asp:ListItem Value="4">9:00am-9:50:am</asp:ListItem>
                <asp:ListItem Value="5">10:00am-10:50am</asp:ListItem>
                <asp:ListItem Value="6">11:00am-11:50am</asp:ListItem>
                <asp:ListItem Value="7">12:00pm-12-50pm</asp:ListItem>
                <asp:ListItem Value="8">1:00pm-1:50pm</asp:ListItem>
                <asp:ListItem Value="9">2:00pm-2:50pm</asp:ListItem>
                <asp:ListItem Value="10">3:00pm-3:50pm</asp:ListItem>
                <asp:ListItem Value="11">4:00pm-4:50pm</asp:ListItem>
                <asp:ListItem Value="12">5:00pm-5:50pm</asp:ListItem>
                <asp:ListItem Value="13">6:00pm-6:50pm</asp:ListItem>
                <asp:ListItem Value="14">7:00pm-7:50pm</asp:ListItem>
                <asp:ListItem Value="15">8:00pm-8:50pm</asp:ListItem>
                <asp:ListItem Value="16">9:00pm-9:50pm</asp:ListItem>
            </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="ButtonFinishReservation" runat="server" BackColor="#006600" ForeColor="White" OnClick="ButtonFinishReservation_Click" Text="Reservar" Visible="False" Width="66px" />
                    </td>
                    <td class="auto-style6">
                        
                        <asp:Button ID="ButtonInsertReservation" runat="server" BackColor="#CC0000" ForeColor="White" OnClick="Button1_Click" Text="Finalizar reservación" Visible="False" Width="224px" />
                        
                    </td>
                </tr>

                </table>
        <asp:Panel ID="Panel1" runat="server">
            <asp:ImageButton ID="ParkinSpace001" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace001_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace002" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace002_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace003" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace003_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace004" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace004_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace005" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace005_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace006" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace006_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace007" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace007_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace008" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace008_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace009" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace009_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace010" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace010_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace011" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace011_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace012" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace012_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace013" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace013_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace014" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace014_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace015" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace015_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace016" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace016_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace017" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace017_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace018" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace018_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace019" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace019_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace020" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace020_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace021" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace021_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace022" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace022_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace023" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace023_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace024" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace024_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace025" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace025_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace026" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace026_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace027" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace027_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace028" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace028_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace029" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace029_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace030" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace030_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace031" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace031_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace032" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace032_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace033" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace033_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace034" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace034_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace035" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace035_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace036" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace036_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace037" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace037_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace038" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace038_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace039" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace039_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace040" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace040_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace041" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace041_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace042" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace042_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace043" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ImageButton13_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace044" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace044_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace045" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace045_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace046" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace046_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace047" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace047_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace048" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace048_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace049" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace049_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace050" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace050_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace051" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace051_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace052" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace052_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace053" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace053_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace054" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace054_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace055" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace055_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace056" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace056_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace057" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace057_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace058" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace058_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace059" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace059_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace060" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace060_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace061" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace061_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace062" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace062_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace063" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace063_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace064" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace064_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace065" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace065_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace066" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace066_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace067" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace067_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace068" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace068_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace069" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace069_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace070" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace070_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace071" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace071_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace072" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace072_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace073" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace073_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace074" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace074_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace075" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace075_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace076" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace076_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace077" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace077_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace078" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace078_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace079" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace079_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace080" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace080_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace081" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace081_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace082" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace082_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace083" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace083_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace084" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace084_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace085" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace085_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace086" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace086_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace087" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace087_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace088" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace088_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace089" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace089_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace090" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace090_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace091" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace091_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace092" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace092_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace093" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace093_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace094" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace094_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace095" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace095_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace096" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace096_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace097" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace097_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace098" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace098_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace099" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace099_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace100" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace100_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace101" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace101_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace102" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace102_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace103" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace103_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace104" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace104_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace105" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace105_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace106" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace106_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace107" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace107_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace108" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace108_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace109" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace109_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace110" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace110_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace111" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace111_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace112" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace112_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace113" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace113_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace114" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace114_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace115" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace115_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace116" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace116_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace117" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace117_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace118" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace118_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace119" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace119_Click" Visible="False" />
            <asp:ImageButton ID="ParkinSpace120" runat="server" ImageUrl="~/emptyParkingSpace.jpg" OnClick="ParkinSpace120_Click" Visible="False" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
