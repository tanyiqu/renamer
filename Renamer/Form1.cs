using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Renamer
{
    public partial class Form1 : Form
    {

        // 当前选择的路径
        private string currPath = "";

        // 当前路径的文件列表
        private List<string> currFiles = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 执行");

//            Util.setItems(ref originList, currFiles);

         //   Util.setItems(ref newList, this.currFiles);

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 还原");
        }


        private void selectDir()
        {
            // 浏览文件夹
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.SelectedPath;
            }
        }

        // 点击选择文件夹
        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 选择文件夹");
            this.selectDir();
        }

        private void txtPath_Click(object sender, EventArgs e)
        {
            Console.WriteLine("点击 选择文件夹");
            this.selectDir();
        }

        // 目录变动回调
        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("文本改变 " + txtPath.Text);

            // 文件夹存在
            if (Util.dirExist(txtPath.Text))
            {
                currPath = txtPath.Text;
                currFiles =  Util.getFiles(currPath);
                Util.setItems(ref originList,currFiles);
                Util.setItems(ref newList, Option.addSequence(currFiles,0,""," "));
            }
            else
            {
                originList.Items.Clear();
                originList.Items.Add("请选择正确的路径！");
                newList.Items.Clear();
                newList.Items.Add("请选择正确的路径！");
            }

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
