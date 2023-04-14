using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFix2.Contrau
{
    public class CustomersController : ApiController
    {
        [HttpGet]
        public List<tblKhach> GetCustomerLists()
        {
            DBCustomersDataContext dbCustomer = new
           DBCustomersDataContext();
            return dbCustomer.tblKhaches.ToList();
        }
        //2. Dịch vụ lấy thông tin một khách hàng với mã nàođó
        [HttpGet]
        public tblKhach GetCustomer(string id)
        {
            DBCustomersDataContext dbCustomer = new
           DBCustomersDataContext();
            return dbCustomer.tblKhaches.FirstOrDefault(x =>
           x.Makhach == id);
        }
        //3. httpPost, dịch vụ thêm mới một khách hàng
        [HttpPost]
        public bool InsertNewCustomer(string id, string name,
       string adress, string phoneNumber)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new
               DBCustomersDataContext();
                tblKhach customer = new tblKhach();
                customer.Makhach = id;
                customer.Tenkhach = name;
                customer.Diachi = adress;
                customer.Dienthoai = phoneNumber;

                dbCustomer.tblKhaches.InsertOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPut]
        public bool UpdateCustomer(string id, string name,
string adress, string phoneNumber)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new
               DBCustomersDataContext();
                //Lấy mã khách đã có
                tblKhach customer =
               dbCustomer.tblKhaches.FirstOrDefault(x => x.Makhach == id);
                if (customer == null) return false;
                customer.Makhach = id;
                customer.Tenkhach = name;
                customer.Diachi = adress;
                customer.Dienthoai = phoneNumber;
                dbCustomer.SubmitChanges();//Xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }
        //5.httpDelete để xóa một Khách hàng
        [HttpDelete]
        public bool DeleteCustomer(string id)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new
              DBCustomersDataContext();
                //Lấy mã khách đã có
                tblKhach customer =
               dbCustomer.tblKhaches.FirstOrDefault(x => x.Makhach == id);
                if (customer == null) return false;

                dbCustomer.tblKhaches.DeleteOnSubmit(customer);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/Customers/SearchCustomersByName/{name}")]
        public List<tblKhach> SearchCustomersByName(string name)
        {
            DBCustomersDataContext db = new DBCustomersDataContext();
            return db.tblKhaches.Where(x => x.Tenkhach.Contains(name)).ToList();
        }
        [HttpGet]
        [Route("api/Customers/SearchCustomersByID/{id}")]
        public List<tblKhach> SearchCustomersByID(string id)
        {
            DBCustomersDataContext db = new DBCustomersDataContext();
            return db.tblKhaches.Where(x => x.Makhach == id).ToList();
        }
        



    }

}

