<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="User_KH.ascx.cs" Inherits="webs_banlaptop.quantri.User_KH" %>
<div class="row element-button">
    <div class="row">
        <div class="col-sm-3">
            <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=userk&suc=newuserk" title="Thêm"><i class="fas fa-plus"></i>
                Tạo mới User Khách Hàng</a>
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
<asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand" OnRowDeleting="GridView2_RowDeleting" OnRowUpdating="GridView2_RowUpdating" Width="1083px">
    <Columns>
        <asp:BoundField DataField="TenTK" HeaderText="tên tk" />
        <asp:BoundField DataField="MatKhau" HeaderText="mật khẩu" />
        <asp:BoundField DataField="email" HeaderText="Email" />
        <asp:ButtonField CommandName="tttk2" HeaderText="" Text='<i class="fas fa-edit"></i>' />
    </Columns>
</asp:GridView>
