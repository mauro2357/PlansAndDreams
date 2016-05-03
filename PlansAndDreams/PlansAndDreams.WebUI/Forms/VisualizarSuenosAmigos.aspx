<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarSuenosAmigos.aspx.cs" Inherits="PlansAndDreams.WebUI.Forms.VisualizarSuenosAmigos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:GridView ID="GrdListaSuenosAmigos" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="IdSueno" HeaderText="Identificador" />
            <asp:BoundField DataField="nombre" HeaderText="Descripción del Sueño" />
        </Columns>
        <EmptyDataTemplate>
            <asp:Label ID="lblGridVacio" runat="server" Text="No hay sueños disponibles."></asp:Label>
        </EmptyDataTemplate>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
