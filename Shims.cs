using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroMQ
{
    public static class Shims
    {
        public static bool IsNullOrWhiteSpace(this string self)
        {
            return self == null || self.Trim().Length == 0;
        }


        public static IntPtr Add(this IntPtr p, int offset)
        {
            return new IntPtr(p.ToInt32() + offset);
        }
    }
}
