<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DsSanPham.aspx.cs" Inherits="ShoesStore.DsSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section> 
        <div>             
            <hgroup>                 
                <h2><%: Page.Title %></h2>             

            </hgroup>             
            <asp:ListView ID="giayList" runat="server" DataKeyNames="MaGiay" GroupItemCount="4" ItemType="ShoesStore.Models.Giay" SelectMethod="GetGiays">                
                <EmptyDataTemplate>                     
                    <table >                         
                        <tr>                             
                            <td>No data was returned.</td>   
                        </tr>     
                    </table>     
                </EmptyDataTemplate>                
                <EmptyItemTemplate>                     
                    <td/>          
                </EmptyItemTemplate>                 
                <GroupTemplate>                     
                    <tr id="itemPlaceholderContainer" runat="server">                         
                        <td id="itemPlaceholder" runat="server"></td>  
                    </tr>    
                </GroupTemplate>                 
                <ItemTemplate>                     
                    <td runat="server">                         
                        <table>                             
                            <tr>                                 
                                <td>                                     
                                    <a href="ChitietSP.aspx?Magiay=<%#:Item.MaGiay%>">  
                                        <img src ="/Images/<%#:Item.Hinhanh%>"  width="150" height="225" style="border:solid" />

                                    </a>  
                                </td>      
                            </tr>                             
                            <tr>                                 
                                <td>                                     
                                    <a href="ChitietSP.aspx?Magiay=<%#:Item.MaGiay%>">
                                        <span>  <%#:Item.TenGiay%> </span>   
                                    </a>                                     
                                    <br />                                     
                                    <span><b>Price: </b><%#:String.Format("{0:c}",Item.Gia)%>  </span> 
                                    <br />
                                    <a href="ThemVaoGioHang.aspx?Magiay=<%#:Item.MaGiay%>">
                                        <span>
                                            <b>Thêm vào Giỏ hàng<b>
                                         </span>
                                     </a>
                                </td>                
                            </tr>                            
                            <tr>                                
                                <td>&nbsp;</td>    
                            </tr>        
                        </table>                    
                        </p>           
                    </td>           
                </ItemTemplate>             
                <LayoutTemplate>                 
                    <table style="width:100%;">                     
                        <tbody>                         
                            <tr>                            
                                <td>                                 
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">                                     
                                        <tr id="groupPlaceholder"></tr>                                 

                                    </table>    
                                </td> 
                            </tr>                        
                            <tr>                            
                                <td></td>   
                            </tr>                         
                            <tr></tr>       
                        </tbody>        
                    </table>     
                </LayoutTemplate>  
            </asp:ListView>   
        </div>     
     </section> 
</asp:Content>
