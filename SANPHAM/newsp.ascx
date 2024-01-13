<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="newsp.ascx.cs" Inherits="webs_banlaptop.SANPHAM.newsp" %>

<div>
    <div class="row element-button">
        <div class="row">
            <div class="col-sm-3">
                <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=prd&suc=newprd" title="Thêm"><i class="fas fa-plus"></i>
                    Thêm Sản Phẩm Mới</a>
            </div>
            <div class="col-sm-2">
                <a style="background-color: DodgerBlue" class="btn btn-add btn-sm" href="admin.aspx?uc=prd&suc=newprd&wart=ttcht" title="Thêm"><i class="fas fa-plus"></i>
                    Thông tin chi tiết sản phẩm</a>
            </div>
            <div class="col-sm-3">
                <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="xóa">
                <asp:LinkButton class="btn btn-add btn-sm" ID="btnxoa" runat="server" OnClick="Button3_Click" CausesValidation="False"><i class="fa-solid fa-trash"></i>Delete</asp:LinkButton></p>
            </div>
            <div class="col-sm-3">
                <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="Thêm mới">
                    <asp:LinkButton class="btn btn-add btn-sm" ID="btnsua" runat="server" OnClick="Button2_Click"><i class="fa-regular fa-file"></i>Thêm Mới</asp:LinkButton>
                    </p>
            </div>
            <div class="col-sm-2">
                <p style="background-color: DodgerBlue" class="btn btn-add btn-sm" title="save">
                    <asp:LinkButton class="btn btn-add btn-sm" ID="btnupdate" runat="server" CausesValidation="False" OnClick="Button1_Click"><i class="fa-solid fa-floppy-disk"></i>Save</asp:LinkButton>
                    </p>
            </div>
        </div>
    </div>
    <hr />
    <asp:PlaceHolder ID="PlaceHolderload" runat="server" EnableTheming="False"></asp:PlaceHolder>
    <div class="row">
        <div class="col-sm-3">
        </div>
        <div class="col-sm-6">
            <div class="row">
                <div class="col-sm-3">
                </div>
                <div style="text-align:center" class="col-sm-6">
                    <asp:LinkButton ID="btncancel" Visible="false" Font-Size="24px" Text="cancel" OnClick="btncancel_Click" runat="server" CausesValidation="False"></asp:LinkButton>
                </div>
                <div class="col-sm-3"></div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-sm-8">
            <div class="row">
                <div class="col-sm-3"><a class="textc">Mã Sản Phẩm:</a></div>
                <br />
                <div class="col-sm-9"><asp:TextBox class="TTNV" Enabled="false" placeholder="Mã Sản Phẩm" ID="txtmahh" runat="server" Width="546px"></asp:TextBox></div>
                <br />
            </div>
            <div style="margin-top: 10px" class="row">
                <div class="col-sm-3"><a class="textc">Tên Sản Phẩm:</a></div>
                <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Tên Sản Phẩm" ID="txttenhh" runat="server" Width="546px"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><a class="textc">Số Lượng:</a></div>
                <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Số Lượng" ID="txtsoluong" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><a class="textc">Số Lượng Tồn:</a></div>
                <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Số Lượng Tồn" ID="txtslton" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
            </div>
            <div class="row">
                <div class="col-sm-3"><a class="textc">Giá Niêm Yết:</a></div>
                <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Giá Niêm Yết" ID="txtgianiemyet" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
            </div>
             <div class="row">
                <div class="col-sm-3"><a class="textc">Giá Bán:</a></div>
                <div class="col-sm-9"><asp:TextBox class="TTNV" placeholder="Giá Bán" ID="txtgiaban" onkeypress="return ValidateKeypress(/\d/,event);" runat="server" Width="546px"></asp:TextBox></div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="row">
                <a>Nhà Cung Cấp <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click" Font-Underline="False">Thêm Nhà Cung Cấp</asp:LinkButton></a>
                <asp:ListBox ID="ListBox1" runat="server" Width="364px">
                </asp:ListBox>
            </div>
            <div class="row">
                <a>Loại Hàng <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" Font-Underline="False" OnClick="LinkButton2_Click">Thêm Loai Hàng</asp:LinkButton></a>
                <asp:ListBox ID="lisbox2" runat="server" Width="363px">
                    <asp:ListItem></asp:ListItem>
                </asp:ListBox>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-4">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUpload1" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;" EnableClientScript="False"></asp:RequiredFieldValidator>
                <asp:Image ID="Image1" runat="server" Height="205px" Width="279px" />
            </div>
            <div class="col-sm-4">
                <asp:FileUpload ID="FileUpload2" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUpload2" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>
                <asp:Image ID="Image2" runat="server" Height="205px" Width="280px" />
            </div>
            <div class="col-sm-4">
                <asp:FileUpload ID="FileUpload3" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FileUpload3" Display="None" ErrorMessage="Bạn cần chọn một tệp ảnh trước khi ấn nút &quot;Upload&quot;"></asp:RequiredFieldValidator>
                <asp:Image ID="Image3" runat="server" Height="205px" Width="278px" />
            </div>
        </div>
        <div class="row">
            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="btnuploadimg_Click" />
        </div>
    </div>
</div>
<style>
    .textc{
        color:blue;
        font-size:14px;
    }
    .TTNV{
        display: block;
    font-size: 15px;
    line-height: 1.5;
    color: black;
    background-color: #f1f1f1;
    background-clip: padding-box;
    border: 1px solid #dadada;
    border-radius: .357rem;
    }
</style>
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
