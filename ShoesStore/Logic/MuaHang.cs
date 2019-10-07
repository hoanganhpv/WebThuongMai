using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoesStore.Models;

namespace ShoesStore.Logic
{
    public class MuaHang : IDisposable
    {
        public string Mamuahang { get; set; }
        private GiayCT _db = new GiayCT();
        public const string CartSessionKey = "CartId";
        public void AddToCart(int id)
        {
            // Retrieve the product from the database.
            Mamuahang = GetCartId();
            var cartItem = _db.MuaHang.SingleOrDefault(
            c => c.MaGiohang == Mamuahang
            && c.MaGiay == id);
            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists.
                cartItem = new GioHang
                {
                    MaHang = Guid.NewGuid().ToString(),
                    MaGiay = id,
                    MaGiohang = Mamuahang,
                    Giay = _db.Giays.SingleOrDefault(p => p.MaGiay == id),
                    SoLuong = 1,
                    DateCreated = DateTime.Now
                };
                _db.MuaHang.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart,
                // then add one to the quantity.
                cartItem.SoLuong++;
            }
            _db.SaveChanges();
        }
        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
        public string GetCartId()
        {
            if (HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] =
                   HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }
        public List<GioHang> GetCartItems()
        {
            Mamuahang = GetCartId();
            return _db.MuaHang.Where(
            c => c.MaGiohang == Mamuahang).ToList();
        }
        public decimal GetTotal()
        {
           Mamuahang = GetCartId();
            // Tổng tiền mỗi cuốn sách (Item Total) = đơn giá (UnitPrice) nhân
            // số lượng (Quantity). Tổng của các tổng tiền chính là
            // số tiền mà người dùng phải trả (Order Total)
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _db.MuaHang
                               where cartItems.MaGiohang == Mamuahang
                               select (int?)cartItems.SoLuong *
                                cartItems.Giay.Gia).Sum();
            return total ?? decimal.Zero;
        }        public MuaHang GetGiohang(HttpContext context)
        {
            using (var cart = new MuaHang())
            {
                cart.Mamuahang = cart.GetCartId();
                return cart;
            }
        }
        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[]
       CartItemUpdates)
        {
            using (var db = new ShoesStore.Models.GiayCT())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<GioHang> myCart = GetCartItems();
                    foreach (var cartItem in myCart)
                    {
                        // Lặp qua các hàng trong giỏ hàng
                        for (int i = 0; i < CartItemCount; i++)
                        {
                            if (cartItem.Giay.MaGiay == CartItemUpdates[i].MaGiay)
                            {
                                if (CartItemUpdates[i].PurchaseQuantity < 1 ||
                               CartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, cartItem.MaGiay);
                                }
                                else
                                {
                                    UpdateItem(cartId, cartItem.MaGiay,
                                   CartItemUpdates[i].PurchaseQuantity);
                                }
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Database - " +
                    exp.Message.ToString(), exp);
                }
            }
        }
        public void RemoveItem(string removeMaGH, int removeMaGiay)
        {
            using (var _db = new ShoesStore.Models.GiayCT())
            {
                try
                {
                    var myItem = (from c in _db.MuaHang
                                  where c.MaGiohang == removeMaGH && c.Giay.MaGiay ==
                                 removeMaGiay
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        // Xóa
                        _db.MuaHang.Remove(myItem);
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Remove Cart Item - " +
                    exp.Message.ToString(), exp);
                }
            }
        }
        public void UpdateItem(string CapnhatMaGH, int CapNhatMagiay, int
        quantity)
        {
            using (var _db = new ShoesStore.Models.GiayCT())
            {
                try
                {
                    var myItem = (from c in _db.MuaHang
                                  where c.MaGiohang== CapnhatMaGH && c.Giay.MaGiay ==
                                 CapNhatMagiay
                                  select c).FirstOrDefault();
                    if (myItem != null)
                    {
                        myItem.SoLuong = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception exp)
                {
                    throw new Exception("ERROR: Unable to Update Cart Item - " +
                    exp.Message.ToString(), exp);
                }
            }
        }
        public void EmptyCart()
        {
            Mamuahang = GetCartId();
            var cartItems = _db.MuaHang.Where(
            c => c.MaGiohang == Mamuahang);
            foreach (var cartItem in cartItems)
            {
                _db.MuaHang.Remove(cartItem);
            }
            // cập nhật
            _db.SaveChanges();
        }
        public int GetCount()
        {
            Mamuahang = GetCartId();
            // Đếm và tính tổng
            int? count = (from cartItems in _db.MuaHang
                          where cartItems.MaGiohang == Mamuahang
                          select (int?)cartItems.SoLuong).Sum();
            // Trả về 0 nếu rỗng
            return count ?? 0;
            return 0;
        }
        public struct ShoppingCartUpdates
        {
            public int MaGiay;
            public int PurchaseQuantity;
            public bool RemoveItem;
        }
    }
}