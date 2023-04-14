using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFix2.Contrau
{
    public class HangSXController : ApiController
    {
        [HttpGet]
        public List<tHangSX> GetCustomerLists()
        {
            DBCustomersDataContext dbCustomer = new DBCustomersDataContext();
            return dbCustomer.tHangSXes.ToList();

        }
        [HttpGet]
        [Route("api/HangSX/SearchhsxByid/{id}")]
        public List<tHangSX> SearchhsxByid(string id)
        {
            DBCustomersDataContext db = new DBCustomersDataContext();
            return db.tHangSXes.Where(x => x.MaHangSX == id).ToList();
        }
    }
}
