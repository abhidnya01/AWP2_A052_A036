<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>
     <div>
    <asp:ListBox id="ListBox1" runat="server" >
     <asp:ListItem value="0">Orange</asp:ListItem>
     <asp:ListItem value="1">Blue</asp:ListItem>
     <asp:ListItem value="2">Green</asp:ListItem>
     <asp:ListItem value="3">Red</asp:ListItem>
     <asp:ListItem value="4">Yellow</asp:ListItem>
    </asp:ListBox><br />
            <asp:Button  ID="Button1" runat="server" Text="Add Items" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/>
            <asp:Button  ID="Button2" runat="server" Text="Remove" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/>
            <asp:Button  ID="Button3" runat="server" Text="Selected Items" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/> 
            <asp:Button  ID="Button4" runat="server" Text="Count" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/> 
            <asp:Button  ID="Button5" runat="server" Text="Clear" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/> 
            <asp:Button  ID="Button6" runat="server" Text="Selected Value" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/>
            <asp:Button  ID="Button7" runat="server" Text="Asach" BorderStyle="Solid" 
            ToolTip="Submit" Width="101px" onclick="Button1_Click"/><br />
     <asp:Label ID="Label6" runat="server"  >label</asp:Label><br />
    <asp:TextBox ID="TextBox1" runat="server" TabIndex ="4" BorderColor="Black" style="margin-top: 17px" 
                  BorderWidth="2px" Font-Name="Arial Black" Visible="true" 
            ontextchanged="TextBox5_TextChanged" Height="33px" Width="277px"></asp:TextBox><br />
       
    </div>

</asp:Content>
