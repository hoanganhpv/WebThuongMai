<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChitietSP.aspx.cs" Inherits="ShoesStore.ChitietSP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="Chitietgiay" runat="server" ItemType="ShoesStore.Models.Giay" SelectMethod ="GetChitiet" RenderOuterTable="false">         
        <ItemTemplate>             
            <div>                 
                <h1><%#:Item.TenGiay %></h1> 
            </div>             
        <br />             
            <table>                 
                <tr>                     
                    <td>                         
                        <img src="/Images/<%#:Item.Hinhanh %>" style="border:solid; height:225px" alt="<%#:Item.TenGiay %>"/> 

                    </td>                     
                    <td>&nbsp;</td>                     
                    <td style="vertical-align: top; text-align:left;">                         
                        <b>Description:</b>
                        <br />
                        <%#:Item.MoTa %>                        
                        <br />                         
                        <span>
                            <b>Price:</b>&nbsp;<%#: String.Format("{0:c}",Item.Gia) %>

                        </span>                         
                        <br />                        
                        <span>
                            <b>Shoes Number:</b>&nbsp;<%#:Item.MaGiay %>
                        </span>                         
                        <br />   
                        <a href="AddToCart.aspx?bookID=<%#:Item.MaGiay%>">
                            <span>
                                <b>Thêm vào Giỏ hàng<b>
                            </span>
                        </a>
                    </td>    
                </tr>    
            </table>   
        </ItemTemplate>   
    </asp:FormView> 
</asp:Content>
