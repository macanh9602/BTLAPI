using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFix2.Contrau
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<tDanhMucSP> GetCustomerLists()
        {
            DBCustomersDataContext dbCustomer = new DBCustomersDataContext();
            return dbCustomer.tDanhMucSPs.ToList();

        }
        //3. httpPost, dịch vụ thêm mới một san pham
        [HttpPost]
        public bool InsertProduct(string MaSP, string TenSP, string MaMau, float Gia, float SoLuong,
            string MaHangSX, string ThoiGianBH, string GioiThieu)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new DBCustomersDataContext();
                tDanhMucSP product = new tDanhMucSP();
                product.MaSP = MaSP;
                product.TenSP = TenSP;
                product.Gia = Gia;
                product.MaMau = MaMau;
                product.MaHangSX = MaHangSX;
                product.SoLuong = SoLuong;
                product.GioiThieu = GioiThieu;
                product.ThoiGianBH = ThoiGianBH;
                dbCustomer.tDanhMucSPs.InsertOnSubmit(product);
                dbCustomer.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        [HttpPut]
        public bool UpdateProduct(string MaSP, string TenSP, string MaMau, float Gia, float SoLuong, 
            string MaHangSX, string ThoiGianBH, string GioiThieu, string MaAnh, string Anh)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new
               DBCustomersDataContext();
                //Lấy mã khách đã có
                tDanhMucSP product =
               dbCustomer.tDanhMucSPs.FirstOrDefault(x => x.MaSP == MaSP);
                product.MaSP = MaSP;
                product.TenSP = TenSP;
                product.MaMau = MaMau;
                product.Gia = Gia;
                product.SoLuong = SoLuong;
                product.MaHangSX = MaHangSX;
                product.ThoiGianBH = ThoiGianBH;
                product.GioiThieu = GioiThieu;
                product.MaAnh = MaAnh;
                product.Anh = Anh;

                dbCustomer.SubmitChanges();//Xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
       
        public bool DeleteProduct(string MaSP)
        {
            try
            {
                DBCustomersDataContext dbCustomer = new
              DBCustomersDataContext();
                //Lấy mã khách đã có
                tDanhMucSP product =
               dbCustomer.tDanhMucSPs.FirstOrDefault(x => x.MaSP == MaSP);
                if (product == null) return false;

                dbCustomer.tDanhMucSPs.DeleteOnSubmit(product);
                dbCustomer.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("api/SanPham/SearchProductsByName/{name}")]
        public List<tDanhMucSP> SearchProductsByName(string TenSP)
        {
            DBCustomersDataContext db = new DBCustomersDataContext();
            return db.tDanhMucSPs.Where(x => x.TenSP.Contains(TenSP)).ToList();
        }
        [HttpGet]
        [Route("api/SanPham/SearchProductsByID/{id}")]
        public List<tDanhMucSP> SearchProductsByID(string MaSP)
        {
            DBCustomersDataContext db = new DBCustomersDataContext();
            return db.tDanhMucSPs.Where(x => x.MaSP == MaSP).ToList();
        }

    }
}
