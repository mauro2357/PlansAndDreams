<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearSueno.aspx.cs" Inherits="PlansAndDreams.WebUI.Forms.CrearSueno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <label></label>
    <form id="form2" runat="server">
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Crear Sueño"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre sueño"></asp:Label>
        <br />
        <input type="text" name="sueno" id="sueno" runat="server" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Fecha para cumplir el sueño"></asp:Label>
        <br />
        <input type="text" name="fecha" id="fecha" runat="server" />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Categoria"></asp:Label>
        <br />
        <input type="text" name="categoria" id="categoria" runat="server" />
        <br />
        <asp:Button Text="Grabar" runat="server" ID="grabar" OnClick="grabar2_Click" />
        <asp:Label ID="mensajeEnPantalla" runat="server" ForeColor="Red" />
    </form>
</body>
</html>
