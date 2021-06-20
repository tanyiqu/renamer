using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Renamer
{
    static class Util
    {

        // 判断目录是否存在
        public static bool dirExist(string path)
        {
            return System.IO.Directory.Exists(path);
        }


        // 获取目录所有文件名
        public static List<string> getFiles(string path) 
        {
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = root.GetFiles();

            List<string> fs = new List<string>();
            foreach (FileInfo fileinfo in files)
            {
                fs.Add(fileinfo.Name);
            }

            return fs;
        }


        // 给ListBox更换Items
        public static void setItems(ref System.Windows.Forms.ListBox listBox, List<string> items)
        {
            // 清除原items
            listBox.Items.Clear();

            // 依次添加
            foreach (string item in items)
            {
                listBox.Items.Add(item);
            }
        }


        // 设置数据
        public static void setData(ref System.Windows.Forms.DataGridView dataGridView, List<string> col1, List<string> col2)
        {
            // 先清空原来的数据
            while (dataGridView.Rows.Count != 0)
            {
                dataGridView.Rows.RemoveAt(0);
            }

            // 依次添加数据
            for (int i = 0; i < col1.ToArray().Length; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView);
                newRow.Cells[0].Value = col1[i];
                newRow.Cells[1].Value = col2[i];
                dataGridView.Rows.Add(newRow);
            }
        }



    }
}
