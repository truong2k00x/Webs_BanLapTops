<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="admin_user.ascx.cs" Inherits="webs_banlaptop.quantri.admin_user" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=user&suc=newuser" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới User Admin</a>
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
    <div class="row">
        <div class="col-sm-2">
            <a class="btn btn-add btn-sm" href="admin.aspx?uc=user" title="Thêm">
                USER Admin</a>
        </div>
        <div class="col-sm-2">
            <a class="btn btn-add btn-sm" href="admin.aspx?uc=userk" title="Thêm">
                USER người dùng</a>
        </div>
    </div>
</div>
<hr />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" Width="1075px">
    <Columns>
        <asp:BoundField DataField="TenAdmin" HeaderText="tên quản trị" />
        <asp:BoundField DataField="TaiKhoan" HeaderText="tài khoản" />
        <asp:BoundField DataField="matKhau" HeaderText="mật khẩu" />
        <asp:ButtonField CommandName="tttk1" Text='<i class="fas fa-edit"></i>' HeaderText="" />
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
