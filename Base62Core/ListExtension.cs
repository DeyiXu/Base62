using System;
using System.Collections.Generic;
using System.Text;

namespace Base62Core
{
    /// <summary>
    /// Listk扩展方法
    /// </summary>
    public static class ListExtension
    {
        public static string ToEncodeString(this List<char> result)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = result.Count - 1; i >= 0; i--)
            {
                sb.Append(result[i]);
            }
            return sb.ToString();
        }
    }
}
