<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tt_sp.ascx.cs" Inherits="webs_banlaptop.SANPHAM.tt_sp" %>

<%@ Register assembly="DevExpress.Web.v22.1, Version=22.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<div>

    <asp:ListBox ID="ListBoxmasp" runat="server" Height="31px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="168px" ClientIDMode="AutoID"></asp:ListBox>
    <asp:Button ID="Button1" runat="server" Text="refresh" CausesValidation="False" OnClick="Button1_Click" />

&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btntt" runat="server" OnClick="btntt_Click" Text="thông tín sp" CausesValidation="False" />

</div>
<div class="row">
    <div class="col-sm-6">
        <div class="row">
            <div class="col-sm-4">Tên Sản Phẩm :</div> <div class="col-sm-8"><asp:TextBox ID="txttensp" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-4">odell :</div> <div class="col-sm-8"><asp:TextBox ID="txtodell" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
        <div class="row">
            <div clas="col-sm-4">CPU :</div> <div class="col-sm-8"><asp:TextBox ID="txtcpu" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-4">Memory :</div> <div class="col-sm-8"><asp:TextBox ID="txtmemory" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-4">SSD :</div> <div class="sol-sm-8"><asp:TextBox ID="txtssd" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
        <div class="row">
            <div class="col-sm-4">VGA :</div> <div class="col-sm-8"><asp:TextBox ID="txtvga" runat="server" style="width:100%"></asp:TextBox></div>
        </div>
<p>
    Display :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtdisplay" runat="server" Width="737px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
<p>
    banphim :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtkey" runat="server" Width="738px"></asp:TextBox>
</p>
<p>
    Camera :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtcamera" runat="server" Width="741px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
    </div>
    <div class="col-sm-6">
    &nbsp;Audio :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtaudio" runat="server" Width="744px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
    &nbsp;Other :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtother" runat="server" Width="747px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
<p>
    Wireless :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtwireless" runat="server" Width="751px"></asp:TextBox>
</p>
<p>
    Battery :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtbettery" runat="server" Width="747px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
<p>
    Weight :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtweight" runat="server" Width="747px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp; 
</p>
<p>
    SoftWare :&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtSW" runat="server" Width="747px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
<p>
    XuatXu :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="txtxuatxu" runat="server" Width="748px"></asp:TextBox>
</p>
<p>
    MauSac :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtcolor" runat="server" Width="746px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    </p>
<p>
    BaoHanh :&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtBH" runat="server" Width="65px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;tháng&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
    &nbsp;&nbsp;
    <asp:Button ID="Buttonluu" runat="server" Text="lưu" OnClick="Buttonluu_Click" CausesValidation="False" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btndelete" runat="server" Text="xóa" CausesValidation="False" />
</p>
    </div>
</div>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" Visible="False">
    <Columns>
        <asp:BoundField DataField="MaHH" HeaderText="Mã Hàng Hóa" />
        <asp:BoundField DataField="odell" HeaderText="odell" />
        <asp:BoundField DataField="CPU" HeaderText="CPU" />
        <asp:BoundField DataField="Memory" HeaderText="Memory" />
        <asp:BoundField DataField="SSD" HeaderText="SSD" />
        <asp:BoundField DataField="VGA" HeaderText="VGA" />
        <asp:BoundField DataField="Display" HeaderText="Display" />
        <asp:BoundField DataField="banphim" HeaderText="Key bord" />
        <asp:BoundField DataField="Camera" HeaderText="Camera" />
        <asp:BoundField DataField="Audio" HeaderText="Audio" />
        <asp:BoundField DataField="Other" HeaderText="Other" />
        <asp:BoundField DataField="Wireless" HeaderText="Wireless" />
        <asp:BoundField DataField="Battery" HeaderText="Battery" />
        <asp:BoundField DataField="Weight" HeaderText="Weight" />
        <asp:BoundField DataField="SoftWare" HeaderText="SoftWare" />
        <asp:BoundField DataField="XuatXu" HeaderText="origin" />
        <asp:BoundField DataField="MauSac" HeaderText="color" />
        <asp:BoundField DataField="BaoHanh" HeaderText="BaoHanh" />
    </Columns>
</asp:GridView>



