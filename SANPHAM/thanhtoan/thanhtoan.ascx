<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="thanhtoan.ascx.cs" Inherits="webs_banlaptop.SANPHAM.thanhtoan.thanhtoan" %>
<div style="margin-top:70px" class="row">
    <a><b>Địa Chỉ Nhận Hàng</b></a>
    <div class="col-sm-3">
        <p>
            Họ tên người nhận: <b><asp:Literal ID="TenKH" runat="server"></asp:Literal></b>
        </p>
        <p>
            Số điện thoại người nhận:   <b><asp:Literal ID="SDT" runat="server"></asp:Literal></b>
        </p>
    </div>
    <div class="col-sm-4">
        <p>
            Địa chỉ nhận hàng:  <b><asp:Literal ID="diachi" runat="server"></asp:Literal></b>
        </p>
    </div>
    <div class="col-sm-3">
        <p>
            Email Xác nhận:  <asp:Literal ID="email" runat="server"></asp:Literal>
        </p>
    </div>
    <div class="col-sm-2">
        <b>
            <asp:Literal ID="Literaltd" runat="server"></asp:Literal>
           
        </b>
    </div>
</div>
<div class="row">
   <%-- <table class="table table-bordered">
        <thead>
            <tr>
                <th>STT</th>
                <th>Ảnh đại diện</th>
                <th>Tên sản phẩm</th>
                <th>Số lượng</th>
                <th>Đơn giá</th>
                <th class="auto-style1">Thành tiền</th>
            </tr>
        </thead>
        <tbody id="datarow">
            <asp:Literal ID="ttsp1" runat="server"></asp:Literal>
        </tbody>
    </table>--%>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating" Width="100%">
        <Columns>
            <asp:CheckBoxField HeaderText="Ảnh Đại Diện" />
            <asp:BoundField DataField="TenHang" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="sl" HeaderText="Số Lượng" />
            <asp:BoundField DataField="GiaBan" HeaderText="Đơn Giá" />
            <asp:ButtonField HeaderText="Thành Tiền" />
            <asp:BoundField DataField="MaHH" HeaderText="MaHH" Visible="False" />
            <asp:ButtonField CommandName="update" Text="&lt;i class='fas fa-edit'&gt;&lt;/i&gt;" />
            <asp:ButtonField CommandName="delete" Text="&lt;i class='fas fa-trash-alt'&gt;&lt;/i&gt;" />
            <asp:TemplateField Visible="False">
                <ItemTemplate>
                    <asp:CheckBox ID="chktem" runat="server" Checked="True" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>
<div class="row">
    <div class="col-sm-8" style="text-align:left">
        <b>Phương Thức Thanh Toán:   </b>
    </div>
    <div style="text-align:right" class="col-sm-4">
        <asp:Literal ID="Literaltt" runat="server"></asp:Literal>
        <button style="background-color:white;color:blue" type="button" class="" data-bs-toggle="modal" data-bs-target="#exampleModal">
            <b>Thay Đổi</b>
        </button>
    </div>
</div>
<div style="text-align:right">
    Miễn Phí Vận Chuyển
</div>
<div class="row">
    <div class="col-sm-10" style="text-align: left"><b>Tổng tiền cần Thanh Toán: </b></div>
    <div style="text-align:right" class="col-sm-2">
        <div><a><b><asp:Literal ID="Literal1" runat="server"></asp:Literal></b></a></div>
        <asp:Button ID="btnad" runat="server" Text="Thanh Toán" OnClick="btnad_Click" CausesValidation="False" />
        <asp:Literal ID="btntt" runat="server"></asp:Literal>
    </div>
</div>
<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Thanh Toán</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <asp:Literal ID="TT_cart" runat="server"></asp:Literal>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <div style="width: 30%; height: auto">
                    <asp:Button ID="Button2" Style="font-size: 10px" runat="server" Text="Thanh Toán Khi Nhận Hàng" OnClick="Button1_Click" />
                </div>
                <div style="text-align: center">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
                <div style="text-align: center">
                    <asp:Image Style="width: 200px; height: auto" ID="Image1" runat="server" />
                </div>
                <%--<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>--%>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
                <asp:Button style="width:20%;height:auto" ID="Button1" runat="server" BorderStyle="none" Text="Hoàn Tất" OnClick="btnad_Click" />
            </div>
        </div>
    </div>
</div>
<div class="modal fade" id="exampleModal1" tabindex="-1" aria-labelledby="exampleModalLabel1" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel1">Địa chỉ nhận hàng</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <asp:Literal ID="Literaldc" runat="server"></asp:Literal>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
            </div>
        </div>
    </div>
</div>
