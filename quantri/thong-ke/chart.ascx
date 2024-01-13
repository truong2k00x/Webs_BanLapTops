<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chart.ascx.cs" Inherits="webs_banlaptop.quantri.thong_ke.chart" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<div style="background-color: white" class="border">
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-6" style="text-align: center; font-size: 30px; color: #0066FF">
            <b>THỐNG KÊ BÁN HÀNG NĂM <asp:Literal ID="lityearlbl" runat="server"></asp:Literal></b>
        </div>
        <div class="col-sm-3">
            <asp:DropDownList ID="dryear" style="margin-top:15px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dryear_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>
<div class="row">
    <div style="margin-left: 10px; margin-right: 10px" class="col-sm-6 border border-3d">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
    <div style="margin-left: -20px;" class="col-sm-6">
        <asp:Chart ID="ChartDBT" runat="server" Style="width: 100%;height:auto" Width="564px" Height="349px" OnLoad="ChartDBC_Load">
            <Series>
                <asp:Series Name="ChartDBT" ChartArea="ChartDBT" ChartType="Pie" LabelBorderWidth="3" YValuesPerPoint="4">
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartDBT">
                </asp:ChartArea>
            </ChartAreas>
            <Titles>
                <asp:Title Font="Microsoft Sans Serif, 16.2pt, style=Bold" ForeColor="#0066FF" Name="ChartDBT" Text="Biểu Đồ Năm">
                </asp:Title>
            </Titles>
        </asp:Chart>
    </div>
</div>
 <div>
    <asp:Chart ID="ChartDBC" runat="server" style="width:100%" Width="1115px" Height="349px" OnLoad="ChartDBC_Load">
        <Series>
            <asp:Series Name="ChartBDC" ChartArea="ChartBDC" ChartType="SplineRange" LabelBorderWidth="3" YValuesPerPoint="4">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartBDC">
            </asp:ChartArea>
        </ChartAreas>
        <Titles>
            <asp:Title Font="Microsoft Sans Serif, 16.2pt, style=Bold" ForeColor="#0066FF" Name="ChartBDC" Text="Biểu Đồ Thống kê">
            </asp:Title>
        </Titles>
    </asp:Chart>
 </div>
    <div style="text-align: center">
        <asp:LinkButton ID="lk1" runat="server" OnClick="LinkButton1_Click"><i class="fa-solid fa-circle-chevron-up fa-rotate-180 fa-2xl"></i></asp:LinkButton>
    </div>
    <div style="margin-top:10px">
        <asp:GridView ID="GridView1" runat="server" style="margin-left:10px;width:100%"  AutoGenerateColumns="False" GridLines="Horizontal">
            <Columns>
                <asp:BoundField DataField="SLdon" HeaderText="Số đơn" />
                <asp:BoundField DataField="MaHH" HeaderText="Mã Hàng Hóa" />
                <asp:BoundField DataField="TenHang" HeaderText="Tên Hàng" />
                <asp:BoundField DataField="sl" HeaderText="Số Lượng" />
                <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
            </Columns>
        </asp:GridView>
    </div>
    
    <div style="text-align: right">
        
        <asp:Literal ID="litsum" runat="server"></asp:Literal>
    </div>
    <div style="text-align:center">
        <asp:LinkButton ID="lk2" runat="server" OnClick="lk2_Click"><i class="fa-solid fa-circle-chevron-up fa-2xl"></i></asp:LinkButton></div>
</div>