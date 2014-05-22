<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IframeTest.aspx.cs" Inherits="MuleSSRS.IframeTest" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <h1>All SSRS Reports</h1>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="testSM"></asp:ScriptManager>
        <div runat="server" id="pnlState">
            <span style="width: 100px">States</span>
            <asp:TextBox runat="server" ID="txtState"></asp:TextBox>
            <asp:Button runat="server" ID="btnReport" OnClick="btnReport_Click" Text="Get States" />
        </div>
        <div>
            <table>
                <tr>
                    <td>
                        <span style="width: 100px">First Name</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFristNameHosp"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">Last Name</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtLastNameHosp"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">SSN</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" Width="70px" ID="txtSSNHosp"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">PAN</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" Width="70px" ID="txtPANHosp"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnHospital" OnClick="btnHospital_Click" Text="Get Hospital Details" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <span style="width: 100px">First Name</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFirstNameLab"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">Last Name</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtLastNameLab"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">SSN</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" Width="70px" ID="txtSSNLab"></asp:TextBox>
                    </td>
                    <td>
                        <span style="width: 100px">PAN</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" Width="70px" ID="txtPANLab"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button runat="server" ID="btnLabMaster" OnClick="btnLabMaster_Click" Text="Get Lab Details" />
                    </td>
                </tr>
            </table>
        </div>
        <div style="padding-left: 90px; padding-top: 20px">
            <rsweb:ReportViewer ID="RptViewer" Width="750px" Height="550px" runat="server">
            </rsweb:ReportViewer>
        </div>
    </form>
</body>
</html>
