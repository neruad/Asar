using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsarGlobal.Web.App_Code.Common;
using System.Configuration;

namespace AsarGlobal.Web.App_Code
{
    public static class Constants
    {
        public static long PhoneNumber = ConfigurationManager.AppSettings["mobile"].ToLong(7759205920);

        public static string PhoneNumberFormatted { get { return PhoneNumber.FormatPhoneNumber(); } }

        public static string Email = ConfigurationManager.AppSettings["email"];

        public static string FacebookProfile = ConfigurationManager.AppSettings["facebook"];

        public static string GooglePlusProfile = ConfigurationManager.AppSettings["googleplus"];

        public static string TwitterProfile = ConfigurationManager.AppSettings["twitter"];

        public static string TelegramChannel = ConfigurationManager.AppSettings["telegramchannel"];
    }
}