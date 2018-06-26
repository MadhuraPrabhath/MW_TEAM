<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SMGame.Home" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    

<div class="container">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <!--<h2>User Details</h2>-->
            <div>
                
            </div>
            <div class="row">
                
                <div class="col-md-8">
           <div class="row">               
                <div class="col-md-12">
                    <span class="label label-default lable-new" style="font-size: medium"></span>
                    <asp:Label runat="server" class="label label-default lable-new1" style="font-size:x-large" id="lblName"></asp:Label>
                </div>
                
            </div>
            <br />
           
           <!-- <div class="row">
                <div class="col-md-12">
                    <span class="label label-default lable-new" style="font-size: medium">Address</span>
                     <asp:Label runat="server" class="label label-default lable-new1" style="font-size: medium" id="lblAddress"></asp:Label>
                </div>

            </div>
            <br />

            <div class="row">
                <div class="col-md-12">
                    <span class="label label-default lable-new" style="font-size: medium">Contact Number</span>
                     <asp:Label runat="server" class="label label-default lable-new1" style="font-size: medium" id="lblContNum"></asp:Label>
                </div>

            </div>-->
            </div>
            </div>


        </div>
        
        </div>
       <br />

            <div class="col-md-12" >
                <h2>Bank Details</h2>
                <asp:DataGrid ID="Grid" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50"  DataKeyField="UserName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="Grid_PageIndexChanged" OnCancelCommand="Grid_CancelCommand" OnDeleteCommand="Grid_DeleteCommand" OnEditCommand="Grid_EditCommand" OnUpdateCommand="Grid_UpdateCommand"> 
                    <Columns>  
                        <asp:BoundColumn HeaderText="User ID" DataField="UserName" Visible="false" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn> 
                         <asp:BoundColumn HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>   
                        <asp:BoundColumn HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Stock Price" DataField="StockPrice" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn DataField="TotalAmount" HeaderText="Total Amount" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn DataField="PxnTypeByeSell" HeaderText="Txn Type" Visible="false" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn DataField="Date" HeaderText="Date" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                    </Columns>  
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />  
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />  
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" BorderWidth="1" BorderColor="Black" />  
                    <AlternatingItemStyle BackColor="White" BorderWidth="1" BorderColor="Black" />  
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />  
                    <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" /> 
                </asp:DataGrid>
                 <br /> <br />  
                <%--<asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />  
                <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />  
                <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />  --%>

            </div> 
        <div class="col-md-7">
            <h2>Available Share Details</h2>
            <asp:DataGrid ID="DataGrid1" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50"  DataKeyField="SectorName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="DataGrid1_PageIndexChanged" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnUpdateCommand="DataGrid1_UpdateCommand"> 
                    <Columns>  
                        <asp:BoundColumn HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black" > </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black" > </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn DataField="StockPrice" HeaderText="Stock Price" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                    </Columns>  
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />  
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />  
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" BorderWidth="1" BorderColor="Black" />  
                    <AlternatingItemStyle BackColor="White" BorderWidth="1" BorderColor="Black" />  
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />  
                    <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" /> 
                </asp:DataGrid>
                 <br /> <br />  
            <%--<table class="table table-responsive table-bordered dataTable text-center">
                <thead>
                    <tr style="font-weight: bold" class="bg-blue">
                        <th>Category</th>
                        <th>Company Name</th>
                        <th>Share Quntity</th>
                        <th>Get Price</th>
                        <th>Current Price</th>
                    </tr>
                </thead>
                <tbody id="tb_ShareDetails" style="font-weight: bold; color: white"></tbody>
            </table>--%>
        </div>
        
        <div class="col-md-7">
            <h2>Share History Details</h2>
            <asp:DataGrid ID="DataGrid2" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50"  DataKeyField="UserName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanged="DataGrid1_PageIndexChanged" OnCancelCommand="DataGrid1_CancelCommand" OnDeleteCommand="DataGrid1_DeleteCommand" OnEditCommand="DataGrid1_EditCommand" OnUpdateCommand="DataGrid1_UpdateCommand"> 
                    <Columns>  
                        <asp:BoundColumn HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black" > </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black" > </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="User ID" DataField="UserName" Visible="false" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn HeaderText="Stock Price" DataField="StockPrice" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <asp:BoundColumn DataField="TotalAmount" HeaderText="Total Amount" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundColumn>  
                        <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                    </Columns>  
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />  
                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />  
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" BorderWidth="1" BorderColor="Black" />  
                    <AlternatingItemStyle BackColor="White" BorderWidth="1" BorderColor="Black" />  
                    <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />  
                    <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" /> 
                </asp:DataGrid>
                 <br /> <br />  
            <%--<table class="table table-responsive table-bordered dataTable text-center">
                <thead>
                    <tr style="font-weight: bold" class="bg-blue">
                        <th>Category</th>
                        <th>Company Name</th>
                        <th>Share Quntity</th>
                        <th>Get Price</th>
                        <th>Sell Price</th>
                    </tr>
                </thead>
                <tbody id="tb_HistoryDetails" style="font-weight: bold; color: white"></tbody>
            </table>--%>
        </div>
        
    </div>
</div>
</asp:Content>