<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="CategoriaSueno.aspx.cs" Inherits="PlansAndDreams.WebUI.Forms.CategoriaSueno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <label></label>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Crear Categoria"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nombre categoria"></asp:Label>
            <br />
            <input type="text" name="categoria" id="categoria" runat="server" />
            <br />
            <asp:Button Text="Grabar" runat="server" ID="grabar" OnClick="grabar_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="mensajeEnPantalla" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
