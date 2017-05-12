﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foyerry.Tools.String
{
    public class StringUtility
    {
        public static T GetVal<T>(object val, T defaultVal)
        {
            var result = defaultVal;
            if (val == null || val == DBNull.Value) return result;
            try
            {
                result = (T)Convert.ChangeType(val, typeof(T));
            }
            catch (InvalidCastException)
            {
            }
            return result;
        }

        public static T As<T>(object val, T defaultVal)
        {
            var result = defaultVal;
            if (val == null || val == DBNull.Value) return result;
            try
            {
                result = (T)Convert.ChangeType(val, typeof(T));
            }
            catch (InvalidCastException)
            {
            }
            return result;
        }
    }
}
