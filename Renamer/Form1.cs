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

            // 浏览文件夹
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("文本改变 " + txtPath.Text);
        }


        // 拖拽获取路径
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        // 拖拽获取路径
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            txtPath.Text = path;
        }


    }
}
