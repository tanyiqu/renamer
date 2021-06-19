using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    class FileItem
    {
        // 文件名
        public string name = "";

        // 不带扩展名的文件名
        public string nameWithoutExt = "";

        // 文件全路径名
        public string fullname = "";

        // 文件所在目录
        public string parentPath = "";

        // 文件扩展名
        public string ext = "";

        // 文件命名后的名字
        public string newName = "";



        public void rename()
        {
            Console.WriteLine("重命名 " + name + " --> " + newName);
        }
    }
}
