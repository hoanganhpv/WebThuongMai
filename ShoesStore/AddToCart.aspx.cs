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
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["BookID"];
            int bookId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out bookId))
            {
                using (ShoppingCartAction usersShoppingCart = new ShoppingCartAction())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ShoesID.");
               
                throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ShoesID.");
           }
            Response.Redirect("ShoppingCart.aspx");

        }
    }
}