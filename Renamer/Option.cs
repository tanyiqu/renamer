using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
    static class Option
    {
        /// <summary>
        /// 添加顺序
        /// </summary>
        /// <param name="inputs">原列表</param>
        /// <param name="offset">偏移，默认为0,末尾添加则为负数</param>
        /// <returns></returns>
        public static List<string> addSequence(List<string> inputs,int offset=0,string pre="",string suf="")
        {
            List<string> outputs = new List<string>();
            if (offset < 0)
            {
                offset = -1;
            }
            int n = 1;
            foreach (string input in inputs)
            {
                string tmpstr = pre + n + suf + input;
                outputs.Add(tmpstr);
                n++;
            }

            return outputs;
        }
    }
}
