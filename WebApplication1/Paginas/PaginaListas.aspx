<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaListas.aspx.cs" Inherits="WebApplication1.Paginas.PaginaListas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 168px;
        }
        .style4
        {
            width: 67px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style4">
                    Automotor</td>
                <td class="style3">
                    <asp:DropDownList ID="ddlAutomotor" runat="server" AutoPostBack="True" 
                        onselectedindexchanged="ddlAutomotor_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Marca</td>
                <td id="ddlMarca" class="style3">
                    <asp:DropDownList ID="ddlMarca" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    Modelo</td>
                <td class="style3">
                    <asp:DropDownList ID="ddlModelo" runat="server" 
                        onselectedindexchanged="ddlModelo_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    
    </div>
    <br />
    <br />
    <asp:ListBox ID="LsbRegistro" runat="server"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" 
        Text="Aceptar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancelar" runat="server" onclick="btnCancelar_Click" 
        Text="Cancelar" />
    <br />
    </form>
</body>
</html>
