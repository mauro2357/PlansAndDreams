<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoriaSueno.aspx.cs" Inherits="PlansAndDreams.WebUI.Forms.CategoriaSueno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <label></label>
    <form id="form1" runat="server">
        <div>
            <input type="text" name="categoria" id="categoria" runat="server" />
            <asp:Button Text="Grabar" runat="server" ID="grabar" OnClick="grabar_Click" />
            <asp:Label ID="mensajeEnPantalla" runat="server" />
        </div>
    </form>
</body>
</html>
