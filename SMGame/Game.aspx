<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" EnableEventValidation="false" Inherits="SMGame.Game" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container">
        <div class="row" style="font-size: large">
            <div class="col-md-3">
                <span runat="server" class="label label-default lable-new">Profit</span>
                <span runat="server" class="label label-default lable-new1" id="lblGame_Profit"></span>
            </div>
            <div class="col-md-3">
                <span class="label label-default lable-new">Name</span>
                <span runat="server" class="label label-default lable-new1" id="lblGame_Name"></span>
            </div>
            <div class="col-md-3">
                <span class="label label-default lable-new">Time left =</span>
                <span runat="server" class="label label-default lable-new1" id="timer"></span>
            </div>
            <div class="col-md-3">
                <span class="label label-default lable-new">Round</span>
                <span runat="server" class="label label-default lable-new1" id="lblGame_Round">1</span>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-1"></div>
            <div class="col-md-8">
                <asp:Button runat="server" ID="btnStartGame" Text="Start Game" CssClass="btn btn-success" Style="width: 100%" OnClick="btnStartGame_Click" Enable="true" />
               <!-- <button runat="server" Style="width: 100%; background-color: #4CAF50; font-size: large"  onclick="startTimer();return false"><b>Start Game</b></button>-->
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-6">
                 <!--  <h3>Stock History Chart</h3>-->
                <div class="card-body">
                    <div class="chart">
                      <!--  <canvas id="lineChart" style="height: 250px"> -->


<div id="chartContainer" style="height: 370px; width: 100%;"></div>
<script src="https://canvasjs.com/assets/script/canvasjs.min.js"></script>



                        <!--</canvas>-->
                    </div>
                </div>
            </div>
           

        </div>

        <br />

        <div class="row">

            <div class="col-md-12">
                <div class="col-md-6">
                    <h3>My Share</h3>
                    <asp:GridView ID="DataGrid2" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50" DataKeyField="UserName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="OnRowDataBound_DataGrid2"
                        OnSelectedIndexChanged="OnSelectedIndexChanged_DataGrid2" Enabled="false">
                        <Columns>
                            <asp:BoundField HeaderText="User ID" DataField="UserName" Visible="false" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Stock Price" DataField="StockPrice" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" BorderWidth="1" BorderColor="Black" />
                        <AlternatingRowStyle BackColor="White" BorderWidth="1" BorderColor="Black" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />
                        <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                    </asp:GridView>
                    <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>

                    <br />
                    <br />
                </div>
                <div class="col-lg-push-6">
                     <div class="col-md-5">
                <div class="col-md-12">
                    <div class="card card-default">
                        <div class="card-header">
                            <h3 class="card-title">
                                <i class="fa fa-bullhorn"></i>
                                Hints
                            </h3>
                        </div>

                        <div class="card-body">
                            <div class="callout callout-danger">
                                <h5>Hey do you want any help?</h5>
                                <p>
                                    
                                </p>
                            </div>

                        </div>

                    </div>

                </div>
            </div>
                </div>
            </div>
        </div>

        <div class="row">

            <div class="col-md-6">
                <div class="col-md-11">
                    <h3>Market Price</h3>
                    <asp:GridView ID="DataGrid3" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50" DataKeyField="SectorName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="OnRowDataBound_DataGrid3"
                        OnSelectedIndexChanged="OnSelectedIndexChanged_DataGrid3" Enabled="false">
                        <Columns>
                            <asp:BoundField HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField DataField="StockPrice" HeaderText="Stock Price" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" BorderWidth="1" BorderColor="Black" />
                        <AlternatingRowStyle BackColor="White" BorderWidth="1" BorderColor="Black" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />
                        <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                    </asp:GridView>
                    <br />
                    <br />
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
            <div class="col-md-11">
                <div class="col-md-12">
                    <h3>Palyers Market</h3>
                    <asp:GridView ID="DataGrid1" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50" DataKeyField="UserName" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="OnRowDataBound_DataGrid1"
                        OnSelectedIndexChanged="OnSelectedIndexChanged_DataGrid1" Enabled="false">
                        <Columns>
                            <asp:BoundField HeaderText="User ID" DataField="UserName" Visible="false" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Sector Name" DataField="SectorName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Company Name" DataField="CompanyName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Stock Quantity" DataField="StockQuantity" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField HeaderText="Stock Price" DataField="StockPrice" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <asp:BoundField DataField="TotalAmount" HeaderText="Total Amount" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"></asp:BoundField>
                            <%--<asp:EditCommandColumn EditText="Edit" CancelText="Cancel" UpdateText="Update" HeaderText="Edit"> </asp:EditCommandColumn>  
                        <asp:ButtonColumn CommandName="Delete" HeaderText="Delete" Text="Delete"> </asp:ButtonColumn>  --%>
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" BorderWidth="1" BorderColor="Black" />
                        <AlternatingRowStyle BackColor="White" BorderWidth="1" BorderColor="Black" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />
                        <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />
                    </asp:GridView>
                    <br />
                    <br />
                </div>
            </div>

        </div>
            </div>
        </div>
        
    </div>


  <!-- The Modal -->
    <link href="Content/Style.css" rel="stylesheet" />
<div id="id01" class="w3-modal">
  <div class="w3-modal-content">
    <div class="w3-container">
      <span onclick="document.getElementById('id01').style.display='none'" 
      class="w3-button w3-display-topright">&times;</span>
     <h2>Sell User Stock</h2>
                   
             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Sector :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblSector"></asp:Label>
                    </div>
                </div>
                <br />

              <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Company :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblCompany"></asp:Label>
                    </div>
                </div>
                <br />

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Stock Quantity :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblStockQty"></asp:Label>
                    </div>
                </div>
                <br />

              

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Enter Stock Quantity :</span>
                        <asp:TextBox ID="txtStockQty" runat="server" Style="font-size: medium"></asp:TextBox>
                    </div>
                </div>
                <br />

<!--Madhura-->
        <%--<div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Sell Price :</span>
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />--%>
        <div class="row">
               <div class="col-md-12">
                   <div class="col-md-2"></div>
                <span class="label label-default lable-new" style="font-size: medium">Sell Price :</span>
                <asp:TextBox ID="txtStockPriceNew" runat="server"></asp:TextBox>
            </div>
            </div>

         <br />

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-10">
                        <asp:Button runat="server" ID="btnBuy" Text="Sell" CssClass="btn btn-success" Style="width: 20%" OnClick="btnBuy_Click" Enable="true" />
                    </div>
                </div>
         <br />
    </div>
  </div>
</div>

    <div id="id02" class="w3-modal">
  <div class="w3-modal-content">
    <div class="w3-container">
      <span onclick="document.getElementById('id02').style.display='none'" 
      class="w3-button w3-display-topright">&times;</span>
     <h2>Buy Market Stock</h2>
             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Sector :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblSector2"></asp:Label>
                    </div>
                </div>
                <br />

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Company :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblCompany2"></asp:Label>
                    </div>
                </div>
                <br />

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Stock Quantity :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblStockQty2"></asp:Label>
                    </div>
                </div>
                <br />

             <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Stock Price :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblStockPrice2"></asp:Label>
                    </div>
                </div>
                <br />

              <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Buy :</span>
                        <asp:TextBox ID="txtStockQty2" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />

               <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-10">
                        <asp:Button runat="server" ID="btnbuy2" Text="Buy" CssClass="btn btn-success" Style="width: 20%" OnClick="btnBuy_Click2" Enable="true" />
                    </div>
                </div>
                <br />
    </div>
  </div>
</div>

      <div id="id03" class="w3-modal">
  <div class="w3-modal-content">
    <div class="w3-container">
      <span onclick="document.getElementById('id03').style.display='none'" 
      class="w3-button w3-display-topright">&times;</span>
     <h2>Buy Palyers Stock</h2>
               <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Sector :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblSector3"></asp:Label>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Company :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblCompany3"></asp:Label>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Stock Quantity :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblStockQty3"></asp:Label>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Stock Price :</span>
                        <asp:Label runat="server" class="label label-default lable-new1" Style="font-size: medium" ID="lblStockPrice3"></asp:Label>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <span class="label label-default lable-new" style="font-size: medium">Buy :</span>
                        <asp:TextBox ID="txtStockQty3" runat="server"></asp:TextBox>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-10">

                        <asp:Button runat="server" ID="btnBuy3" Text="Buy" CssClass="btn btn-success" Style="width: 20%" OnClick="btnBuy_Click3" Enable="true" />
                    </div>

                </div>
                <br />
    </div>
  </div>
</div>

    <div id="id04" class="w3-modal">
  <div class="w3-modal-content">
    <div class="w3-container">
     <h2>Winner's List <asp:Label runat="server" class="label label-default lable-new1" id="lblRoundNumber"></asp:Label></h2>
        <div class="row">               
            <div class="col-md-12">
                <asp:GridView ID="gvWinner" runat="server" BorderWidth="1" BorderColor="Black" PageSize="50"  DataKeyField="Rank" AllowPaging="True" AutoGenerateColumns="false" CellPadding="4" ForeColor="#333333" GridLines="None">  
                    <Columns>  
                        <asp:BoundField HeaderText="Rank" DataField="Rank" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundField>  
                        <asp:BoundField HeaderText="User Name" DataField="UserName" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundField> 
                        <asp:BoundField HeaderText="Total Amount" DataField="TotalAmount" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black"> </asp:BoundField>  
                    </Columns>  
                     <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" />  
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" BorderWidth="1" BorderColor="Black" />  
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center"  BorderWidth="1" BorderColor="Black" />  
                    <AlternatingRowStyle BackColor="White" BorderWidth="1" BorderColor="Black" />  
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" BorderWidth="1" BorderColor="Black" />  
                    <HeaderStyle BackColor="#008085" Font-Bold="True" ForeColor="White" BorderWidth="1" BorderColor="Black" /> 
                </asp:GridView>
                 <br />  
            </div>
             <div class="col-md-12">
                 <%--<button onclick="play();return false">Next Round</button>--%>
               <asp:Button runat="server" ID="btnNextRound" Text="Next Round" CssClass="btn btn-success" style="width: 20%" OnClick="btnNextRound_Click" Enable="true"  />
            </div>
            <br />
        </div>
        <br />
    </div>
  </div>
</div>
    <script src="Content/Game.js"></script>
    <script src="Content/ChartJS.js"></script>
   
</asp:Content>
