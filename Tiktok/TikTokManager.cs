using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok
{
    class TikTokManager
    {
        private static string FILENAME;
        private static List<TikTok> = new List<TikTok>();
            
            static void ReadfromFile(string tiktok)
        {
            TextReader read = new StreamReader(tiktok);
            string line = reader.ReadLine();
            
            while (line != null)
            {
                Parse(line);
                TikTok.add();
                line = reader.ReadLine();
               
            }
           
            reader.close();


        }
    }
}
