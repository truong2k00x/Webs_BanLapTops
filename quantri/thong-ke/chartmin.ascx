<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chartmin.ascx.cs" Inherits="webs_banlaptop.quantri.thong_ke.chartmin" %>

<div style="text-align: center; text-align: center; font-size: 20px; color: #0066FF"><b>Kiểm Tra Thống kê</b></div>
    <div class="row">
        <div class="col-sm-6">
            Tháng<asp:DropDownList ID="drmonth" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="col-sm-6" style="text-align:right">
            Theo Sản Phẩm <asp:CheckBox ID="ck1" runat="server" AutoPostBack="True" OnCheckedChanged="ck1_CheckedChanged" />
        </div>
    </div>
<div>
    <div class="row">
        <div class="col-sm-8">
            <asp:DropDownList ID="DropDownList1" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged1" runat="server"></asp:DropDownList>
        </div>
        <div style="text-align: right; margin-top: 22px" class="col-sm-4">
        </div>
    </div>
    <asp:GridView ID="grvsp" class="border" Style="width: 100%" runat="server"></asp:GridView>
    <asp:Chart ID="ChartBD" runat="server" Style="width: 100%" Width="1115px" Height="349px">
        <Series>
            <asp:Series Name="ChartBD" ChartArea="ChartBD" LabelBorderWidth="3" YValuesPerPoint="6">
            </asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartBD">
            </asp:ChartArea>
        </ChartAreas>
        <Titles>
            <asp:Title Font="Microsoft Sans Serif, 16.2pt, style=Bold" ForeColor="#0066FF" Name="ChartBD" Text="Biểu Đồ Thống kê">
            </asp:Title>
        </Titles>
    </asp:Chart>
</div>