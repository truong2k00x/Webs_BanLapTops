<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nhanvien.ascx.cs" Inherits="webs_banlaptop.NhanVien.Nhanvien" %>

<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=crs&suc=newcrs" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới Nhân Viên</a>
        </div>
        <div class="col-sm-2"></div>
        <div style="text-align-last:right" class="col-sm-6">
            <label style="font-weight: 600; white-space: nowrap; text-align: left; background: white; color: black; padding: 10px; border-radius: .357rem; border: 1px solid #ddd;">Tìm kiếm:
                <asp:TextBox Height="100%" Style="margin-left: 0.5em; display: inline-block; width: auto;" ID="TextBox1" runat="server"></asp:TextBox></label>
           
        </div>
        <div class="col-sm-1">
            <asp:LinkButton ID="btnsr" Width="10px" Height="10px" runat="server" CausesValidation="False" OnClick="btnsr_Click"><i class="fa-solid fa-magnifying-glass"></i></asp:LinkButton>
        </div>
    </div>
</div>
<hr />
<asp:GridView Style="border: 9px solid #dee2e6;width: 100%; max-width: 100%; margin-bottom: 1rem; background-color: transparent;"
    ID="NhanVienGRV" runat="server" AutoGenerateColumns="False" CaptionAlign="Bottom" OnRowCommand="NhanVienGRV_RowCommand" BorderStyle="Inset" BorderWidth="4px" CellSpacing="2">
    <Columns>
        <asp:BoundField DataField="MaNV" HeaderText="Mã Nhân Viên" />
        <asp:BoundField DataField="TenNV" HeaderText="Tên Nhân Viên" />
        <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
        <asp:BoundField DataField="DienThoai" HeaderText="Điện Thoại" />
        <asp:BoundField DataField="SCCCD" HeaderText="Số Căn Cước Công Dân" />
        <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" />
        <asp:ButtonField CommandName="TT" HeaderText="" Text='<i class="fas fa-edit"></i>' />
    </Columns>

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


