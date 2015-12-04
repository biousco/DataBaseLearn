using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string passWord)
        {
            string message = "";
            int code = 0;
            User user = new User();
            user.AdminUser = userName;
            user.AdminPwd = passWord;
            if (BLL.sysLogin(user) > 0)
            {
                code = 1;
            }
            else
            {
                    message = "用户名或密码 错误，请重新输入！";
                    //code = 0;
            }
            // 以 json 格式返回数据
            JsonResult ajaxRes = new JsonResult();
            ajaxRes.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ajaxRes.Data = new { message = message, code = code };
            return ajaxRes;
        }
    }
}