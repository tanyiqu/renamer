using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 执行");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 还原");
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 选择文件夹");
        }
    }
}
