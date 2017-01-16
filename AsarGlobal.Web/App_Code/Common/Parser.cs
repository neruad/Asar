using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsarGlobal.Web.App_Code.Common
{
    public static class Parser
    {
        public static long ToLong(this string value, long defaultValue = 0)
        {
            if (value == null)
                return defaultValue;
            var result = value.ToLong();
            if (result == null)
                return defaultValue;
            else
                return result.Value;
        }

        public static long? ToLong(this string value)
        {
            if (value == null)
                return null;

            long result;
            if (long.TryParse(value, out result))
            {
                return result;
            }
            return null;
        }
    }
}