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
        public static List<FileItem> getFiles(string path) 
        {
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = root.GetFiles();

            // 依次获取文件内容
            List<FileItem> fs = new List<FileItem>();
            foreach (FileInfo fileinfo in files)
            {
                FileItem fi = new FileItem();
                fi.name = fileinfo.Name;
                fi.nameWithoutExt = fileinfo.Name;

                fi.fullname = fileinfo.FullName;
                fi.parentPath = fileinfo.FullName;
                fi.newName = fileinfo.Name;

                fs.Add(fi);
            }

            return fs;
        }


        // 设置数据
        public static void setData(ref System.Windows.Forms.DataGridView dataGridView, List<FileItem> fileItems)
        {
            // 先清空原来的数据
            while (dataGridView.Rows.Count != 0)
            {
                dataGridView.Rows.RemoveAt(0);
            }

            // 依次添加数据
            foreach (FileItem f in fileItems)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView);
                newRow.Cells[0].Value = f.name;
                newRow.Cells[1].Value = f.newName;
                dataGridView.Rows.Add(newRow);
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
