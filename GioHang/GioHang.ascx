<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GioHang.ascx.cs" Inherits="webs_banlaptop.GioHang.GioHang1" %>
<div style="text-align:center">
    <asp:Label align="center" ID="lbltbao" runat="server" Font-Size="78px"></asp:Label>
</div>
<div>
    <a href="index.aspx" style="font-size:25px;color:black;text-underline-position:under">Tiếp Tục Mua Hàng</a></div>
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
    
<div class="mt-4">
    <div id="thongbao" class="alert alert-danger d-none face" role="alert">
    </div>
    <div class="row">
        <div class="col-sm-10">
        </div>
        <div class="col-sm-2">
            <asp:LinkButton align="right" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Visible="False"><i class="fa-solid fa-arrows-rotate"></i></asp:LinkButton>
        </div>
    </div>
    <div>
        <asp:Label align="right" Width="100%" ID="lbltongtien" runat="server" Text="Tổng Tiền:"></asp:Label>
    </div>
    <div class="row">
        <div class="col-md-9"></div>
        <div class="col-md-3">
            <asp:Button ID="btndat" runat="server" OnClick="Button1_Click" Text="Đặt Hàng" Height="39px" /></div>
    </div>
</div>
<script>
            $(document).ready(function () {
                $(window).scroll(function () {
                    if ($(this).scrollTop()) {
                        $('header').addClass('sticky');
                    }
                    else {
                        $('header').removeClass('sticky');
                    }
                });
            });
</script>

<script>
    function deleteRow(r) {
        var i = r.parentNode.parentNode.rowIndex;
        document.getElementById("myTable").deleteRow(i);
    }
    jQuery(function () {
        jQuery(".trash").click(function () {
            swal({
                title: "Cảnh báo",
                text: "Bạn có chắc chắn là muốn xóa sản phẩm này?",
                buttons: ["Hủy bỏ", "Đồng ý"],
            })
                .then((willDelete) => {
                    if (willDelete) {
                        swal("Đã xóa thành công.!", {

                        });
                    }
                });
        });
    });
    oTable = $('#sampleTable').dataTable();
    $('#all').click(function (e) {
        $('#sampleTable tbody :checkbox').prop('checked', $(this).is(':checked'));
        e.stopImmediatePropagation();
    });
</script>
