<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="etd_task.ascx.cs" Inherits="webs_banlaptop.SANPHAM.thanhtoan.NganHang.etd_task" %>
<%@ Register Assembly="DevExpress.Web.v22.1, Version=22.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<div style="font-size:40px;color:dodgerblue;text-align:center">
    Extended Task
</div>

<div style="background-color:azure" class="row">
    <div style="font-size: 30px">
        <b>Thông Tin Tài Khoản:</b>
    </div>
    <div class="col-sm-4">
        <div><b>Ngân Hàng:</b></div>
        <asp:DropDownList Style="margin-top: 20px;" ID="drops" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drops_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="col-sm-4">
        <div><b>Số Tài Khoản:</b></div>
        <div style="margin-top: 20px;" class="border border-3">
            <asp:TextBox Width="100%" onkeypress="return ValidateKeypress(/\d/,event);" ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div class="col-sm-4">
        <div><b>Tên Tài Khoản:</b></div>
        <div style="margin-top: 20px;" class="border border-3">
            <asp:TextBox Width="100%" ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </div>
    </div>
    <div style="margin-top:20px;display:flex">
    <button type="button" style="text-align: center; color: #0099ff" data-bs-toggle="modal" data-bs-target="#exampleModal" class="border border-5">Add Cart</button>
    </div>
    <div style="text-align:right">
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click1">check_QR</asp:LinkButton>
    </div>
    <div style="text-align:center">
        <asp:Image ID="img" runat="server" />
    </div>
</div>
<div style="margin-top:10px;background-color: azure" class="row">

</div>
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <asp:Literal ID="renewpass" runat="server"></asp:Literal>
                <h1 class="modal-title fs-5" id="exampleModalLabel">Bạn Muốn Thêm Tài Khoản</h1>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div style="color:cornflowerblue;margin-top:30px;text-align:center">
                <asp:Label ID="lblautt" runat="server" Text=""></asp:Label>
            </div>
            
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">NO</button>
                <asp:LinkButton class="btn btn-primary" type="button" ID="txtbtnsave" runat="server" OnClick="txtbtnsave_Click">YES</asp:LinkButton>
            </div>
        </div>
    </div>
</div>

