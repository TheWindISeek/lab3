using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 输入一个正整数 逆序打印出每一个位数
            // 编程找出1000以内所有的完数 一个完数所有的因子的和刚好是完数
            //对输入的一组数据进行排序
            Application.Run(new Form1());
        }
    }
}
