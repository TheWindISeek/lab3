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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private const int N = 20;
        private double[] x = new double[20];
        private int index = 0;
        /// <summary>
        /// 将输入框中的数据以空格为分界 添加到数组序列中去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                string[] ss = textBox1.Text.Split(' ');
                textBox2.Text = "";
                foreach (string s in ss)
                {
                    //转换成浮点数
                    x[index] = double.Parse(s);
                    //添加到排序前数组序列中
                    textBox2.Text += s + " ";
                    //下标修改
                    index = (index + 1)%N;
                }
            } catch (Exception ex)
            {
                ex.Source = "Error";
            }

        }
        /// <summary>
        /// 排序按钮监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortButton_Click(object sender, EventArgs e)
        {
            Array.Sort(x, 0, index);
            textBox3.Text = "";
            for(int i = 0; i < index; i++)
            {
                textBox3.Text += x[i].ToString() + " ";
            }
        }
    }
}
