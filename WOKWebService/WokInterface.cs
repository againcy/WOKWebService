using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WokSearchLite;
namespace WOKWebService
{
    public class test
    {
        public int a;
        public string b;
    }

    public class WokInterface
    {
        string auth;
        WOKMWSAuthenticateService authserv = new WOKMWSAuthenticateService();
        public bool authenticate()
        {
            try
            {
                auth = authserv.authenticate();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void testfunc()
        {
            test tmp = new test() { a = 1, b = "111" };
            StringWriter sw = new StringWriter();
            //WriteXML(new test() { a = 1, b = "haah" },System.Console.Out);
        //WriteXML(tmp,sw);
            XmlWriter<test>(tmp, sw);
            Console.WriteLine(sw);
        
        }

        static public void XmlWriter<T>(T t, TextWriter tw)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            xs.Serialize(tw, t);
        }

        /*public static void WriteXML(Object obj, System.IO.TextWriter file)
        {
            
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Object));
            writer.Serialize(file, obj);
            //file.Close();
        }*/

        int count;
        public void reportProgress(int num,int total)
        {
            System.Console.WriteLine("retrieving "+num+" of "+total+" in Journal "+this.journalnickname);
        }

        public void reportProgress(string s)
        {
            System.Console.WriteLine(s);
            
        }

        public void recorddata(searchResults sr, string path)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\LiuYibin\Documents\Visual Studio 2012\Projects\WOKWebService\WOKWebService\WOKWebService\records\" + path);
            XmlWriter<searchResults>(sr, sw);
            sw.Close();
        }
        public string journalnickname;
        public void retrieveRest()
        {
            int start = 1;
            while (start <= count)
            {
                retrieveParameters rp = new retrieveParameters();
                rp.count = count-start+1>100?100:count-start+1;
                rp.firstRecord = start;
                rp.sortField = null;

                var t = b.retrieve("1", rp);
                //reportProgress(start + 100 - 1);
                recorddata(t,journalnickname + "_retrieve_" + start + "_" + (start + 100 - 1) + ".xml");
                start += 100;
            }
        }
        WokSearchLiteService b;
        /// <summary>
        /// the sort field is different than the other two methods
        /// </summary>
        /// <param name="name"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public searchResults searchByJournalName(string name, int start, int count)
        {
            b = new WokSearchLiteService();
            queryParameters q = new queryParameters();
            q.databaseId = "WOK";
            q.queryLanguage = "en";
            //q.symbolicTimeSpan = "";
            q.timeSpan = new timeSpan();
            q.timeSpan.begin = "2003-01-01";
            q.timeSpan.end = "2014-12-31";
            q.userQuery = "SO = " + name;//"SO = IEEE transactions on software engineering";
            retrieveParameters r = new retrieveParameters();
            r.sortField = new sortField[1];
            r.sortField[0] = new sortField();
            r.sortField[0].name = "PY";
            r.sortField[0].sort = "D";
            r.firstRecord = start;
            r.count = count;
            
            //b.CookieContain
            b.CookieContainer = new System.Net.CookieContainer();
            b.CookieContainer.Add(new Uri("http://search.webofknowledge.com/esti/wokmws/ws/WokSearch"), new Cookie("SID", auth));
            searchResults sr = b.search(q, r);
            return sr;
            //count = sr.recordsFound;
        }

        public void searchByJournalName(string name, int start)
        {
            b = new WokSearchLiteService();
            queryParameters q = new queryParameters();
            q.databaseId = "WOK";
            q.queryLanguage = "en";
            //q.symbolicTimeSpan = "";
            q.timeSpan = new timeSpan();
            q.timeSpan.begin = "1980-01-01";
            q.timeSpan.end = "2011-01-01";
            q.userQuery = "SO = " + name;//"SO = IEEE transactions on software engineering";
            retrieveParameters r = new retrieveParameters();
            r.sortField = null;
            r.firstRecord = start;
            r.count = 100;
            //b.CookieContain
            b.CookieContainer = new System.Net.CookieContainer();
            b.CookieContainer.Add(new Uri("http://search.webofknowledge.com/esti/wokmws/ws/WokSearch"), new Cookie("SID", auth));
            searchResults sr = b.search(q, r);
            count = sr.recordsFound;

        }

        public void searchByJournalName(string name)
        {
            //WokSearchLiteService.WokSearchLiteService b = new WokSearchLiteService.WokSearchLiteService();
            b = new WokSearchLiteService();
            queryParameters q = new queryParameters();
            q.databaseId = "WOK";
            q.queryLanguage = "en";
            //q.symbolicTimeSpan = "";
            q.timeSpan = new timeSpan();
            q.timeSpan.begin = "1980-01-01";
            q.timeSpan.end = "2011-01-01";
            q.userQuery = "SO = "+name;//"SO = IEEE transactions on software engineering";
            retrieveParameters r = new retrieveParameters();
            r.sortField = null;
            r.firstRecord = 1;
            r.count = 5;
            //b.CookieContain
            b.CookieContainer = new System.Net.CookieContainer();
            b.CookieContainer.Add(new Uri("http://search.webofknowledge.com/esti/wokmws/ws/WokSearch"), new Cookie("SID", auth));
            searchResults sr = b.search(q, r);
            count = sr.recordsFound;
            //XmlWriter<searchResults>(sr, System.Console.Out);
            

            /*foreach (var i in sr.records)
                System.Console.WriteLine("authors: " + i.authors);// + "" +i.keywords+ "" + "" + "");*/
            //System.Console.WriteLine(b.search(q, r));
        }
    }
}
