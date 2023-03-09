using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle
{
    public partial class PerfectNumber : Form
    {
        public PerfectNumber()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            int range = 0;
            try
            {
                range = Convert.ToInt32(input.Text);
            } catch (Exception ex)
            {
                ex.Source = "Error";
            }
            output.Text = getPerfectNumber(range);
        }

        private String getPerfectNumber(int range)
        {
            StringBuilder result = new StringBuilder();
            Queue<int> q = new Queue<int>();
            if (range == 0)
            {
                return result.ToString();
            }

            int sum = 0, n = 0;
            // 迭代查找完美数
            for(int i = 6; i < range; ++i)
            {
                //对于每个数 看他的因子和
                //1 肯定是因子 所以sum至少为1
                sum = 1;
                n = i;
                q.Clear();
                for(int j = 2; j <= n/2; ++j)
                {
                    if(n % j == 0)
                    {
                        sum += j;
                        q.Enqueue(j);
                    }
                }
                //判断是否是完美数
                if(sum == i)
                {
                    result.Append(i + "是一个完美数 = 1");
                    while(q.Count != 0)
                    {
                        result.Append(" + " + q.Dequeue());
                    }
                    result.Append('\n');
                }
            }

            return result.ToString();
        }
    }
}
