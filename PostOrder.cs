using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle
{
    public partial class PostOrder : Form
    {
        public PostOrder()
        {
            InitializeComponent();
        }
        //原谅我偷懒 把代码写得这么烂
        private void trans_Click(object sender, EventArgs e)
        {
            int pre = 0;
            try
            {
                pre = Convert.ToInt32(input.Text);
            }catch (Exception ex)
            {
                ex.Source = "Error";
            }
            output.Text = "";
            get_post_order(pre);
        }

        private void get_post_order(int id)
        {
       
            output.Text += (id%10).ToString();
            if(id >= 10)
            {
                get_post_order(id / 10);
            }
        }
    }
}
