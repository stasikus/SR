using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneRadomize
{
    public class OutRandomInfo
    {

        public static void saveToInfo(string path, Panel p1)
        {
            Thread tr = new Thread(() => save(path, p1));
            tr.IsBackground = true;
            tr.Start();
        }
        
        public static void save(string path, Panel panel)
        {
            string s;
            for (int i = 0; i < LoadList.newList.Count; i++)
            {
                StreamWriter sw = new StreamWriter(@"" + path + "\\out_clean_list.txt", true, System.Text.Encoding.UTF8);
                s = LoadList.newList[i];
                sw.WriteLine(s);
                sw.Close();
                s = "";
            }
            MessageBox.Show("Готово");

            panel.BeginInvoke((Action)delegate
            {
                panel.Enabled = true;
            });
        }
    }
}
