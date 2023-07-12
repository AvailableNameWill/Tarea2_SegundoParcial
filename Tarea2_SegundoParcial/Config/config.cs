using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea2_SegundoParcial.Config
{
    public class config{
        public static string domain = "jsonplaceholder.typicode.com";
        public static string subDomain1 = "posts";
        public static string subDomain2 = "posts/";
        public static string postNum = "";
        public static string formatUrl1 = "https://{0}/{1}";
        public static string formatUrl2 = "https://{0}/{1}/{2}";

        public static string apiGet1 = string.Format(formatUrl1, domain, subDomain1);
        public static string apiGet2 = string.Format(formatUrl2, domain, subDomain1, postNum);

        public static string getApi2(string _postNum){
            string api = string.Format(formatUrl2, domain, subDomain1, _postNum);
            return api;
        }
    }
}
