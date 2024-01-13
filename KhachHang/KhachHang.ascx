<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.ascx.cs" Inherits="webs_banlaptop.KhachHang.KhachHangcl" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v22.1, Version=22.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>

<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=cus&suc=newcus" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới Thông tin Khách Hàng</a>
        </div>
        <div class="col-sm-2"></div>
        <div style="text-align-last: right" class="col-sm-6">
            <label style="font-weight: 600; white-space: nowrap; text-align: left; background: white; color: black; padding: 10px; border-radius: .357rem; border: 1px solid #ddd;">
                Tìm kiếm:
                <asp:TextBox Height="100%" Style="margin-left: 0.5em; display: inline-block; width: auto;" ID="TextBox1" runat="server"></asp:TextBox></label>

        </div>
        <div class="col-sm-1">
            <asp:LinkButton ID="btnsr" Width="10px" Height="10px" runat="server" CausesValidation="False" OnClick="btnsr_Click"><i class="fa-solid fa-magnifying-glass"></i></asp:LinkButton>
        </div>
    </div>
</div>
<hr />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="1088px" OnRowCommand="GridView1_RowCommand">
    <Columns>
        <asp:BoundField DataField="MaKH" HeaderText="Mã Khách Hàng" />
        <asp:BoundField DataField="TenKH" HeaderText="Tên Khách Hàng" />
        <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />
        <asp:BoundField DataField="DienThoai" HeaderText="Số Điện Thoại" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:BoundField DataField="TenTK" HeaderText="TenTK" />
        <asp:ButtonField CommandName="HT" HeaderText="" Text='<i class="fas fa-edit"></i>' />
    </Columns>
</asp:GridView>

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
