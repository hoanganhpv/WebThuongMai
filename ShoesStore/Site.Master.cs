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
        public IQueryable<NSX> GetNSXs()
        {
            var _db = new ShoesStore.Models.GiayCT();
            IQueryable<NSX> query = _db.NSXs;
            return query;
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            using (MuaHang usersShoppingCart = new
            MuaHang())
            {
                string cartStr = string.Format("Giỏ hàng ({0})",
                usersShoppingCart.GetCount());
                cartCount.InnerText = cartStr;
            }
        }
    }
}