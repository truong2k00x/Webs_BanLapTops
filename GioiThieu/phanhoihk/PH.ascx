<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PH.ascx.cs" Inherits="webs_banlaptop.GioiThieu.phanhoihk.PH" %>
<%@ Register Assembly="DevExpress.Web.v22.1, Version=22.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<div><a style="text-align:center"><asp:Literal ID="MaHD" runat="server"></asp:Literal></a></div>
<div><a style="font-size:30px;color:black"><b>Chất Lượng Phục Vụ !</b></a></div>
<div><a>
    <asp:LinkButton ID="s1" Font-Size="70px" ForeColor="LightGray" runat="server" OnClick="s1_Click"><i class="fa-solid fa-star"></i></asp:LinkButton>
    <asp:LinkButton ID="s2" Font-Size="70px" ForeColor="LightGray" runat="server" OnClick="s2_Click"><i class="fa-solid fa-star"></i></asp:LinkButton>
    <asp:LinkButton ID="s3" Font-Size="70px" ForeColor="LightGray" runat="server" OnClick="s3_Click"><i class="fa-solid fa-star"></i></asp:LinkButton>
    <asp:LinkButton ID="s4" Font-Size="70px" ForeColor="LightGray" runat="server" OnClick="s4_Click"><i class="fa-solid fa-star"></i></asp:LinkButton>
    <asp:LinkButton ID="s5" Font-Size="70px" ForeColor="LightGray" runat="server" OnClick="s5_Click"><i class="fa-solid fa-star"></i></asp:LinkButton>
</a></div>
<div><a style="color:red"><i class="fa-sharp fa-regular fa-circle-exclamation"></i></a><a>Lưu Ý: 1 sao 'Rất Tệ',2 sao 'Không Hài Lòng',3 sao 'Khá Hài Lòng',4 sao'Hài Lòng',5 sao 'rất hài lòng'</a></div>
<div><a style="font-size: 30px; color: black">Ý Kiến Bổ Xung:</a></div>
<div>
    <asp:TextBox ForeColor="LightGray" Style="background-color: LightGray;color:black" ID="TextBox1" runat="server" Height="273px" Width="1299px" TextMode="MultiLine"></asp:TextBox>
    <br />
</div>
<div>
    <div class="row">
        <div class="col-sm-6">
            <asp:Button ID="Button1" runat="server" Text="Gửi Đánh Giá" OnClick="Button1_Click" />
        </div>
        <div class="col-sm-6">
            <asp:Button ID="Button2" runat="server" Text="Để Sau" OnClick="Button2_Click" />
        </div>
    </div>
</div>
<script>
    function myfunction(a) {
        if (a == 1) {
            let element = document.getElementById('ctl11_s1');
            element.style.ForeColor = '#f2d976';
        }
    }
</script>