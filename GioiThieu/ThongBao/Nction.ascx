<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Nction.ascx.cs" Inherits="webs_banlaptop.GioiThieu.ThongBao.Nction" %>
<asp:Literal ID="thongbao" runat="server"></asp:Literal>
<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <asp:Literal ID="renewpass" runat="server"></asp:Literal>
                <h1 class="modal-title fs-5" id="exampleModalLabel">ĐỔI MẬT KHẨU</h1>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div>
                <asp:Label ID="txtcanhbao" runat="server" Text=""></asp:Label>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>
