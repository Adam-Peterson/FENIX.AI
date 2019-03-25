<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AzureMLAPI.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>FENIX.AI Client Consulting Matching</title>
<link rel="stylesheet" runat="server" media="screen" href="~/content/styles.css" />

</head>
<body>




    <div class="container">  
    <form id="contact" runat="server">
    <h3>FENIX.AI Customer Registration Form</h3>
    <h4>Input Client information to be matched with a consultant</h4>
    
        Industry Field
    <fieldset>
<asp:DropDownList ID="industryList" runat="server">
                    <asp:ListItem Value="Education">Education</asp:ListItem>
                    <asp:ListItem Value="Technology">Technology</asp:ListItem>
                    <asp:ListItem Value="Retail">Retail</asp:ListItem>
                    <asp:ListItem Value="Other">Other</asp:ListItem>
                    </asp:DropDownList>    

    </fieldset>
    <fieldset>
                    <asp:TextBox ID="dti" runat="server" placeholder="Project Hours">
                    </asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Hours are Required" ForeColor="Red" ControlToValidate="dti" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator type="Integer" ID="RangeValidator2" runat="server" ErrorMessage="Number of Hours must be a whole number between 0 to 1000" ForeColor="Red" ControlToValidate="dti" MaximumValue="1000" MinimumValue="0" Display="Dynamic"></asp:RangeValidator>
    </fieldset>
    <fieldset>
      <input placeholder="Special Comments or Requests (optional)" type="tel" tabindex="3">
    </fieldset>
    <fieldset>
      <input placeholder="Client Referral Code (optional)" type="url" tabindex="4">
    </fieldset>
   
    <fieldset>
        <asp:LinkButton ID="lbPredict" type="submit" runat="server" OnClick="lbPredict_Click">Match</asp:LinkButton>
    </fieldset>
                <asp:Label ID="lblResults" runat="server" Font-Size="Large"></asp:Label>

  </form>
</div>














</body>
</html>
