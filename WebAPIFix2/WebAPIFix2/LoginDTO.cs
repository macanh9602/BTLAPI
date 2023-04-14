using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIFix2
{
    public class LoginDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public string XacNhanMatKhau { get; set; }
    }
}