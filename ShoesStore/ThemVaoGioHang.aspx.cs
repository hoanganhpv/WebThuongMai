using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using ShoesStore.Logic;

namespace ShoesStore
{
    public partial class ThemVaoGioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["MaGiay"];
            int magiay;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out magiay))
            {
                using (MuaHang usersShoppingCart = new MuaHang())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ShoesID.");

                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ShoesID.");
            }
            Response.Redirect("GioHang.aspx");

        }
    }
}