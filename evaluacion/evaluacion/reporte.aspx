﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reporte.aspx.cs" Inherits="evaluacion.reporte" %>

<!DOCTYPE html>
<script runat="server">


    protected void ddNombres_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
        <asp:DropDownList ID="ddNombre" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddNombres_SelectedIndexChanged">
        </asp:DropDownList>
    
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
