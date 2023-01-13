using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectManager.Module.BusinessObjects
{
    public class httpObsluga
    { 
        public string baseAdress = "https://wyszukiwarkaregontest.stat.gov.pl/wsBIR/UslugaBIRzewnPubl.svc";
        public string testToken = "abcde12345abcde12345";

        public string TestGet() {
            string testRequest = "";
            var request = HttpWebRequest.CreateHttp(baseAdress+"Zaloguj"+testToken);
            return testRequest;
        }
   








    }
}
