using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Regx
{
    public static class RegxString
    {
        /// <summary>
        /// 数字
        /// </summary>
        public const string Number = "^[0-9]*$";

        /// <summary>
        /// N为设置
        /// <para>0-数字位数(N)</para>
        /// </summary>
        public const string SeresNumber = @"^\d{0}$ ";
    }
}
