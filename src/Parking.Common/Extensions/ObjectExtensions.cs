using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static int TryParseToInt32(this object obj)
        {
            int ret = 0;

            try
            {
                ret = Convert.ToInt32(obj);
            }
            catch (Exception)
            {
            }

            return ret;
        }
    }
}
