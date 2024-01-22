using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.CharacterCreator2D.Creator_UI.Scripts.Textual_Generator
{
    class FileReader
    {
        public static string ReadData(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Program to show content of test file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                str += sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return str;
        }
    }
}
