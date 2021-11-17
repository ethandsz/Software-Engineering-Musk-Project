using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteInspection
{
    class logbook
    {
        private String logbook_file = "logbook.txt";
        private StreamWriter write;

        private static logbook _instance;

        public static logbook _Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new logbook();
                return _instance;
            }

        }


        public logbook()
        {
            try
            {

                write = new StreamWriter(logbook_file, true);
            }
            catch (IOException e) { }
        }
        public void wrt(String msg)
        {

            write.WriteLine(msg);
        }
        public void Close()
        {
            write.Close();
        }
    }
}
