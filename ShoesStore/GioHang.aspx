<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="ShoesStore.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead"><h1>Shopping
Cart</h1></div>
     <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False"
                 ShowFooter="True" GridLines="Vertical" CellPadding="4"
                 ItemType="ShoesStore.Models.GioHang"
                 SelectMethod ="GetShoppingCartItems"
                 CssClass="table table-striped table-bordered" >
         <Columns><asp:BoundField DataField="MaGiay" HeaderText="Mã"
                            SortExpression="MaGiay" />
             <asp:BoundField DataField="Giay.TenGiay" HeaderText="Tên" />
             <asp:BoundField DataField="Giay.Gia" HeaderText="Giá (mỗi cái)"
                             DataFormatString="{0:c}"/>
             <asp:TemplateField HeaderText="Số lượng">
                 <ItemTemplate>
                     <asp:TextBox ID="PurchaseQuantity" Width="40"
                     runat="server" Text="<%#: Item.SoLuong %>"></asp:TextBox>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Item Total">
                 <ItemTemplate>
                     <%#: String.Format("{0:c}",
                     ((Convert.ToDouble(Item.SoLuong)) *
                    Convert.ToDouble(Item.Giay.Gia)))%>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="Đổi SP">
                 <ItemTemplate>
                    <asp:CheckBox id="Remove" runat="server"></asp:CheckBox>
                 </ItemTemplate>
             </asp:TemplateField>
         </Columns>
      </asp:GridView>
        <div>
             <p></p>
                 <strong>
                     <asp:Label ID="LabelTotalText" runat="server" Text="Tổng tiền"></asp:Label>
                     <asp:Label ID="lblTotal" runat="server" EnableViewState="false"></asp:Label>
                 </strong>
        </div>
        <br />    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" Text="Cập Nhật"
                OnClick="UpdateBtn_Click" />
            </td>
        </tr>
</table>
</asp:Content>
