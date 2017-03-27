<%@ Page Title="Star Wars Characters" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Starwars.aspx.cs" Inherits="IAmTheLastJedi.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Here you can load a list of Star Wars Characters </h3>
    <p>Click the button below to load the character list from file People.json to a Grid View. Click a charcter in the list to open their details further.</p>
    <p>
        <asp:Button ID="btnRun" runat="server" OnClick="btnRun_Click" Text="Run" />
    </p>
    
    <div class="spacer">
        &nbsp;
    </div>

    <div>
        <asp:GridView ID="gvPeople" runat="server" CssClass="Grid" OnSelectedIndexChanged="gvPeople_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>

    <div class="spacer">
        &nbsp;
    </div>

    <div id="dvPersonDetails" runat="server" visible="false">
        <div>
            <asp:Label id="lblName" runat="server" Text="Name" Width="200" />
            <asp:TextBox ID="txtName" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblHeight" runat="server" Text="Height" Width="200" />
            <asp:TextBox ID="txtHeight" runat="server" Width="300" ReadOnly="True" Enabled="false"  />
        </div>
        <div>
            <asp:Label id="lblMass" runat="server" Text="Mass" Width="200" />
            <asp:TextBox ID="txtMass" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblHairColour" runat="server" Text="Hair Colour" Width="200" />
            <asp:TextBox ID="txtHairColour" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblSkinColour" runat="server" Text="Skin Colour" Width="200" />
            <asp:TextBox ID="txtSkinColour" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblEyeColour" runat="server" Text="Eye Colour" Width="200" />
            <asp:TextBox ID="txtEyeColour" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblBirthYear" runat="server" Text="Birth Year" Width="200" />
            <asp:TextBox ID="txtBirthYear" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblGender" runat="server" Text="Gender" Width="200" />
            <asp:TextBox ID="txtGender" runat="server" Width="300" Enabled="false" ReadOnly="True" />
        </div>
        <div>
            <asp:Label id="lblHomeworld" runat="server" Text="Home World" Width="200" />
            <asp:TextBox ID="txtHomeWorld" runat="server" Width="300" ReadOnly="True" Enabled="false"  />
        </div>
        <div>
            <asp:Label id="lblFilms" runat="server" Text="Films" Width="200" />
            <asp:TextBox ID="txtFilms" runat="server" Width="300" ReadOnly="True" Enabled="false" Rows="5" TextMode="MultiLine" />
        </div>
        <div>
            <asp:Label id="lblSpecies" runat="server" Text="Species" Width="200" />
            <asp:TextBox ID="txtSpecies" runat="server" Width="300" ReadOnly="True" Enabled="false" Rows="5" TextMode="MultiLine" />
        </div>
        <div>
            <asp:Label id="lblVehicles" runat="server" Text="Vehicles" Width="200" />
            <asp:TextBox ID="txtVehicles" runat="server" Width="300" ReadOnly="True" Enabled="false" Rows="5" TextMode="MultiLine" />
        </div>
        <div>
            <asp:Label id="lblStarships" runat="server" Text="Starships" Width="200" />
            <asp:TextBox ID="txtStarships" runat="server" Width="300" ReadOnly="True" Enabled="false" Rows="5" TextMode="MultiLine" />
        </div>
        <div>
            <asp:Label id="lblCreated" runat="server" Text="Created" Width="200" />
            <asp:TextBox ID="txtCreated" runat="server" Width="300" ReadOnly="True" Enabled="false" />
        </div>
        <div>
            <asp:Label id="lblEdited" runat="server" Text="Edited" Width="200" />
            <asp:TextBox ID="txtEdited" runat="server" Width="300" ReadOnly="True" Enabled="false"  />
        </div>
        <div>
            <asp:Label id="lblUrl" runat="server" Text="URL" Width="200" />
            <asp:TextBox ID="txtUrl" runat="server" Width="300" ReadOnly="True" Enabled="false"  />
        </div>
    </div>


</asp:Content>
