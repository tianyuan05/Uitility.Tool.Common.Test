using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class StringExtension
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// MD5加密 (支持加盐)
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key">种子:NULL-不加盐加密</param>
        /// <returns></returns>
        public static string ToMD5(this string value, string key = null)
        {
            var md5 = Security.Cryptography.MD5.Create();

            if (!key.IsNullOrWhiteSpace())
                value += key;

            var bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(value));

            var sb = new StringBuilder();
            foreach (var item in bytes)
            {
                sb.Append(item.ToString("x2"));
            }

            return sb.ToString();
        }


    }
}
