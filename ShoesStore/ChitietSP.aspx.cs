using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoesStore.Models;
using System.Web.ModelBinding;

namespace ShoesStore
{
    public partial class ChitietSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Giay> GetChitiet([QueryString("maGiay")] int? magiay)
        {
            var _db = new ShoesStore.Models.GiayCT();
            IQueryable<Giay> query = _db.Giays;
            if (magiay.HasValue && magiay > 0)
            {
                query = query.Where(p => p.MaGiay == magiay);
            }
            else { query = null; }
            return query;
        }
    }
}