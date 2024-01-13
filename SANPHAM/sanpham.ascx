<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sanpham.ascx.cs" Inherits="webs_banlaptop.SANPHAM.sanpham" %>

<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=prd&suc=newprd" title="Thêm"><i class="fas fa-plus"></i>
                Thêm Săn Phẩm</a>
        </div>
        <div class="col-sm-2"></div>
        <div style="text-align-last: right" class="col-sm-6">
            <label style="font-weight: 600; white-space: nowrap; text-align: left; background: white; color: black; padding: 10px; border-radius: .357rem; border: 1px solid #ddd;">
                Tìm kiếm:
                <asp:TextBox Height="100%" Style="margin-left: 0.5em; display: inline-block; width: auto;" ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="btnsearch_Click"></asp:TextBox></label>

        </div>
        <div class="col-sm-1">
            <asp:LinkButton ID="btnsr" Width="10px" Height="10px" runat="server" CausesValidation="False" OnClick="btnsearch_Click"><i class="fa-solid fa-magnifying-glass"></i></asp:LinkButton>
        </div>
    </div>
</div>
<hr />
<asp:GridView ID="SanPhamGRV" runat="server" CaptionAlign="Bottom" CellPadding="2" BorderStyle="Outset" BorderWidth="4px" CellSpacing="2" AutoGenerateColumns="False" OnRowCommand="SanPhamGRV_RowCommand" OnSelectedIndexChanged="SanPhamGRV_SelectedIndexChanged" Width="1134px">
    <Columns>
        <asp:BoundField DataField="MaHH" HeaderText="Mã Hàng Hóa" />
        <asp:BoundField DataField="TenHang" HeaderText="Tên Hàng" />
        <asp:BoundField DataField="MaLH" HeaderText="Mã Loại Hàng" />
        <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
        <asp:BoundField DataField="SLTon" HeaderText="Số Lượng Tồn" />
        <asp:BoundField DataField="GiaNiemYet" HeaderText="Giá Niêm Yết" />
        <asp:BoundField DataField="GiaBan" HeaderText="Giá Bán" />
        <asp:BoundField DataField="MaNCC" HeaderText="MaNCC" Visible="False" />
        <asp:ButtonField CommandName="SP" HeaderText="" Text='<i class="fa-sharp fa-regular fa-pen-to-square"></i>' />
    </Columns>
    <RowStyle BorderColor="Black" BorderStyle="Outset" BorderWidth="4px" />
    <EditRowStyle BorderColor="#CC0099" BorderStyle="Groove" BorderWidth="10px" />
    <EmptyDataRowStyle BorderStyle="Double" BorderWidth="11px" />
    <HeaderStyle BorderStyle="Dashed" />
    <RowStyle BorderStyle="Solid" />
</asp:GridView>

<div>
</div>
<script>
    function ValidateKeypress(numcheck, e) {
        var keynum, keychar, numcheck;
        if (window.event) {//IE
            keynum = e.keyCode;
        }
        else if (e.which) {// Netscape/Firefox/Opera
            keynum = e.which;
        }
        if (keynum == 8 || keynum == 127 || keynum == null || keynum == 9 || keynum == 0 || keynum == 13) return true;
        keychar = String.fromCharCode(keynum);
        var result = numcheck.test(keychar);
        return result;
    }
</script>



