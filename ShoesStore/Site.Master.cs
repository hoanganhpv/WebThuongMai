using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoesStore.Logic;
using ShoesStore.Models;

namespace ShoesStore
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Category> GetCategories()
        {
            var _db = new ShoesStore.Models.BookContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (ShoppingCartAction usersShoppingCart = new
            ShoppingCartAction())
            {
                string cartStr = string.Format("Giỏ hàng ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}