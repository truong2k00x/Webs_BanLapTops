<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="donhang.ascx.cs" Inherits="webs_banlaptop.HoaDon.donhang" %>
<div style="text-align:center"><a style="text-align:center;font-size:45px;color:blue">Xác Nhận Đơn Hàng</a></div>
<div><asp:ListBox ID="ListBox1" runat="server" Height="44px" Width="394px" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
    <asp:ListItem Value="2" Selected="False">Đã Xác Nhận</asp:ListItem>
    <asp:ListItem Value="1" Selected="True">Chờ Xác Nhân</asp:ListItem>
    <asp:ListItem Value="3" Selected="False">Đang Vận Chuyển</asp:ListItem>
    <asp:ListItem Value="4" Selected="False">Giao Hàng Thành Công</asp:ListItem>
    <asp:ListItem Value="5" Selected="False">Đơn Đã Hủy</asp:ListItem>
    </asp:ListBox><a>       </a><asp:LinkButton Font-Size="30px" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="fa-solid fa-arrows-rotate"></i></asp:LinkButton></div>
<asp:GridView Style="border: 9px solid #dee2e6; width: 100%; max-width: 100%; margin-bottom: 1rem; background-color: transparent;" AutoGenerateColumns="False" CaptionAlign="Bottom" BorderStyle="Inset" BorderWidth="4px" CellSpacing="2" ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="MaHD" HeaderText="Mã Hóa Đơn" />
        <asp:BoundField DataField="TongGiaTri" HeaderText="Tổng Giá Trị" />
        <asp:BoundField DataField="NgayLap" HeaderText="Ngày Lập" />
        <asp:BoundField DataField="MaTrangThai" HeaderText="Trạng Thái" />
        <asp:ButtonField CommandName="check" Text="check" />
    </Columns>
</asp:GridView>

