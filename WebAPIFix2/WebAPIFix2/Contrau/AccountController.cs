using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIFix2.Contrau
{
    public class AccountController : ApiController
    {
        [HttpGet]
        public List<tblTaiKhoan> GetAccountLists()
        {
            DBCustomersDataContext dbCustomer = new
           DBCustomersDataContext();
            return dbCustomer.tblTaiKhoans.ToList();
        }
        [HttpPost]
        [Route("api/Account/Login")]
        public IHttpActionResult Login([FromBody] LoginDTO login)
        {
            using (var db = new DBCustomersDataContext())
            {
                var TaiKhoan = login.TaiKhoan;
                var MatKhau = login.MatKhau;

                // Tìm kiếm thông tin tài khoản trong cơ sở dữ liệu
                var user = db.tblTaiKhoans.FirstOrDefault(x => x.TaiKhoan == TaiKhoan && x.MatKhau == MatKhau);

                if (user == null)
                {
                    return BadRequest("Sai tên tài khoản hoặc mật khẩu");
                }

                // Tạo và trả về một token hoặc một đối tượng JSON chứa thông tin tài khoản
                var token = "abcxyz";
                var result = new
                {
                    ID = user.ID,
                    TaiKhoan = user.TaiKhoan,
                    MatKhau = user.MatKhau ,
                    MaKhach = user.Makhach,
                    Token = token
                };

                return Ok(result);
            }
        }
        [HttpPost]
        [Route("api/Account/Register")]
        public IHttpActionResult Register([FromBody] tblTaiKhoan account1)
        {
            try
            {
                if (account1 == null || string.IsNullOrEmpty(account1.TaiKhoan) || string.IsNullOrEmpty(account1.MatKhau) || string.IsNullOrEmpty(account1.XacNhanMatKhau))
                {
                    return BadRequest("Vui lòng nhập đầy đủ thông tin tài khoản");
                }
                using (var db = new DBCustomersDataContext())
                {
                    var TaiKhoan = account1.TaiKhoan;
                    // Kiểm tra xem tài khoản đã tồn tại hay chưa
                    var existingAccount = db.tblTaiKhoans.FirstOrDefault(a => a.TaiKhoan == TaiKhoan);
                    if (existingAccount != null)
                    {
                        return BadRequest("Tài khoản đã tồn tại");
                    }
                    // Kiểm tra xem mật khẩu đã trùng khớp hay chưa
                    if (account1.MatKhau != account1.XacNhanMatKhau)
                    {
                        return BadRequest("Mật khẩu không trùng khớp");
                    }

                    var newAccount = new tblTaiKhoan
                    {
                        TaiKhoan = account1.TaiKhoan,
                        MatKhau = account1.MatKhau
                    };

                    // Thêm tài khoản mới vào cơ sở dữ liệu
                    db.tblTaiKhoans.InsertOnSubmit(newAccount);
                    db.SubmitChanges();

                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
