<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberShipRegister.aspx.cs" Inherits="MemberShipWebForms.MemberShipLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Register<div style="height: 457px; width: 844px;">
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" Height="440px" OnCreatedUser="CreateUserWizard1_CreatedUser" Width="566px">
                <WizardSteps>
                    <asp:CreateUserWizardStep runat="server" />
                    <asp:CompleteWizardStep runat="server" />
                </WizardSteps>
            </asp:CreateUserWizard>
    </div>
    </form>
    </body>
</html>
