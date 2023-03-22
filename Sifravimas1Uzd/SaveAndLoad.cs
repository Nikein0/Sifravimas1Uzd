using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifravimas1Uzd
{
    internal class SaveAndLoad
    {
        private static string Filename;
        private string path = "C:\\Users\\t430\\source\\repos\\Sifravimas1Uzd\\Sifravimas1Uzd\\file.txt";


        public SaveAndLoad(string filename) {
            Filename = filename;
        }
        public void Save(string encryptedText)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(encryptedText);
            }
        }
        public string Load() {
            return null;
        }



    }
}
