using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
   public  class Utility
    {
       //通用类，检查数据输入是否规范
       ///////////检查手机号码是否规范
       public static bool CheckMobilePhone(string phone)
       {
           bool check = true;
           //if (phone != "")
           //{
           //    if (phone.Length != 11 || !Regex.IsMatch(phone,
           //        @"13[0123456789]\d{8} |15[0123456789]\d{8} |18{0123456789}\d{8}"))
           //    {
           //        check = false;
           //    }
           //}
           return check;
       
       }

       ///////检查email格式是否规范
       public static bool CheckEmail(string email)
       {
           bool check = true;
           //if (email  != "")
           //{
           //    if ( !Regex.IsMatch(email,
           //        @"\w+([-+.])\w+)*@\w+([-.])\w+)*\.\w+([-.]\w+)*"))
           //    {
           //        check = false;
           //    }
           //}
           return check;

       }

       ///////检查qq格式是否规范
       public static bool CheckQQ(string qq)
       {
           bool check = true;
           //if (qq != "")
           //{
           //    if (!Regex.IsMatch(qq,
           //        @"^[1-9])*[1-9][0-9]*$"))
           //    {
           //        check = false;
           //    }
           //}
           return check;

       }
       ///////检查电话号码格式是否规范
       public static bool CheckPhone(string phone)
       {
           bool check = true;
           //if (phone != "")
           //{
           //    if (!Regex.IsMatch(phone,
           //        @"^(0[0-9]{2,3}\-)?([2-9][0-9]{6,7})+(\-[0-9]{1,4})?$"))
           //    {
           //        check = false;
           //    }
           //}
           return check;

       }




    }
}
