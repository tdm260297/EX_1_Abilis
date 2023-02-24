

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlibisEX1.aspx.cs" Inherits="EX_1_Abilis.AlibisEX1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multiplication Table</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Multiplication Table</h1>
            <p>
                Matrix Size:
                <asp:DropDownList ID="ddlMatrixSize" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMatrixSize_SelectedIndexChanged"></asp:DropDownList>
            </p>
            <p>
                Matrix Base:
                <asp:RadioButtonList ID="rblMatrixBase" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblMatrixBase_SelectedIndexChanged">
                    <asp:ListItem Value="decimal">Decimal</asp:ListItem>
                    <asp:ListItem Value="binary">Binary</asp:ListItem>
                    <asp:ListItem Value="hex">Hex</asp:ListItem>
                </asp:RadioButtonList>
            </p>
            <asp:Table ID="tblMultiplicationTable" runat="server"></asp:Table>
        </div>
    </form>
</body>
</html>

