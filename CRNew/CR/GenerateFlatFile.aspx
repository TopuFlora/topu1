<%@ Page Title="" Language="C#" MasterPageFile="~/CR/Site.Master" AutoEventWireup="true" CodeBehind="GenerateFlatFile.aspx.cs" Inherits="FloraSoft.CR.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Standard Charge</h4>
    <hr />
    <br />

    <td>
        <asp:DropDownList ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Text="001" Value="1"></asp:ListItem>
            <asp:ListItem Text="031" Value="2"></asp:ListItem>
            <asp:ListItem Text="040" Value="3"></asp:ListItem>
            <asp:ListItem Text="041" Value="4"></asp:ListItem>
        </asp:DropDownList>
    </td>

     <%--<asp:GridView ID="gvStandardCharge" runat="server" AlternatingRowStyle-BackColor="White"
            AutoGenerateColumns="False" BorderWidth="0px" Height="0px" CellPadding="5" CellSpacing="1"
            GridLines="None" HeaderStyle-BackColor="#F2DEDE" RowStyle-BackColor="#EEEEEE"
            Width="993px" DataKeyNames="ChargeID" 
            onrowcommand="gvStandardCharge_RowCommand" PageSize="15" OnSelectedIndexChanged="gvStandardCharge_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ChargeID" HeaderText="ChargeID" Visible="false" />
                <asp:BoundField DataField="GHO" HeaderText="GHO" />
                <asp:BoundField DataField="Commission" HeaderText="Commission" />
                <asp:BoundField DataField="VAT" HeaderText="VAT" />
              
                      <asp:BoundField DataField="StatusName" HeaderText="Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnApprove" runat="server" CommandName="Approve" Text='<%# Bind("StatusName") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandName="ChargeEdit" Height="24px"
                            ImageUrl="~/CR/Images/edit.jpg" Width="25px" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandName="ChargeDelete" Height="20px" ImageUrl="~/CR/Images/delete.jpg"
                            Width="25px" />
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnDisapprove" runat="server" CommandName="DisApprove" Height="20px" Text="Disapproved" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
        </asp:GridView>--%>

        <hr />
    <br />
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="GenerateFlatFile" CssClass="btn btn-success" OnClick="btnAdd_Click" />
    </div>

</asp:Content>
