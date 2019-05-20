<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavMenu.ascx.cs" Inherits="DevPortal.controls.NavMenuascx" %>

<ul class="nav">

    <asp:Repeater ID="rptTopLevelMenu" runat="server" DataSourceID="dsMenuAccess">
        <ItemTemplate>

            <li class="nav-item">
                <a class="nav-link active" href="/">
                    <i class="nav-icon fas fa-th fa-lg"></i><%#Eval("MenuItemName") %>
                </a>
            </li>
            <asp:Repeater ID="rptChildLevelMenu" runat="server">
                <ItemTemplate>
                </ItemTemplate>
            </asp:Repeater>

        </ItemTemplate>
    </asp:Repeater>


    <asp:SqlDataSource runat="server" ID="dsMenuAccess" ConnectionString='<%$ ConnectionStrings:Portal %>' SelectCommand="SELECT Menu.MenuItemName FROM Menu LEFT JOIN MenuAccessLevels ON Menu.MenuID = MenuAccessLevels.MenuID
WHERE AccessLevelID = @AccessLevelID">
        <SelectParameters>
            <asp:Parameter DefaultValue="1" Name="AccessLevelID"></asp:Parameter>
        </SelectParameters>
    </asp:SqlDataSource>
</ul>
