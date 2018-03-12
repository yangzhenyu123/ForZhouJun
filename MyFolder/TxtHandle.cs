using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyFolder
{
    public class TxtHandle
    {
        public static void OutTXTByString(string strsE, string filename)
        {


            try
            {

                string dirPath = "D:\\ZhouJunLog\\";
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }


                filename = "D:\\ZhouJunLog\\" + filename+".txt";

                string path = filename;

                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }

                strsE = strsE + "\r\n";

                StreamWriter writer = new StreamWriter(path, true, Encoding.Default, 500);
                writer.Write(strsE.ToString());
                writer.Close();
                writer.Dispose();
            }
            catch
            {

            }

        }
    }
}
