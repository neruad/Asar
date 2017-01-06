using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AsarGlobal.Web.App_Code.Common;

namespace AsarGlobal.Web.App_Code
{
    public static class Constants
    {
        public static long PhoneNumber = 7759205920;

        public static string PhoneNumberFormatted { get { return PhoneNumber.FormatPhoneNumber(); } }

        public static string Email = "aidana.agp@gmail.com";

        public static string FacebookProfile = "https://www.facebook.com/aidana.agp";

        public static string GooglePlusProfile = "https://plus.google.com/116167424516397692476";

        public static string TwitterProfile = "https://twitter.com/aidana_agp";
    }
}