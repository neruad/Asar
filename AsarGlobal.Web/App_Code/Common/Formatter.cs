using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsarGlobal.Web.App_Code.Common
{
    public static class Formatter
    {
        public static string FormatPhoneNumber(this long phoneNumber)
        {
            return "+7 " + phoneNumber.ToString("000 000 00 00");
        }
    }
}