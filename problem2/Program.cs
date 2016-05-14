using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            var files = dir.GetFiles();
            foreach (var t in files)
            {
                FileStream fs = new FileStream(@t.FullName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string str = sr.ReadLine();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'a' && str[i + 1] == 'b' && str[i + 2] == 'c' && str[i + 3] == 'd')
                    {
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    Console.WriteLine(t.Name);

                }
                cnt = 0;

                sr.Close();
                fs.Close();

            }
            
            Console.ReadKey();
        }
    }
}
