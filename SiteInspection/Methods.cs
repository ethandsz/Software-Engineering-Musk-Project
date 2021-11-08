using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteInspection
{
    class Methods
    {
        string pWord;
        
        public void setPassword(string pass)
        {
            pWord = pass;
        }

        public string getPassword()
        {
            return pWord;
        }
    }
}
