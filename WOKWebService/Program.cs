using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WokSearchLite;
using System.IO;

namespace WOKWebService
{
    class Program
    {
        /*string[] nicknames=
        {
            "chem_rev",
            "CHEM_SOC_REV"
            Nat_chem

                           };
        string[] names=
        {
            "Chemical Reviews",
            "Chemical Society Reviews",
            Nature Chemistry
    Accounts of Chemical Research
        };*/
        //static void get
        static void reportError(string txt)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\LiuYibin\Documents\Visual Studio 2012\Projects\WOKWebService\WOKWebService\WOKWebService\records\Error.txt",true);
            sw.WriteLine(txt);
            sw.Close();
        }
        static void Main(string[] args)
        {
            //ACCOUNTS OF CHEMICAL RESEARCH
            //args = new string[5];
            //args[0] = "chemical"; 
            //args[1] = "reviews"; 
            //args[2] = "chemical"; 
            //args[3] = "research";
            
            //WokInterface.testfunc();
            
            /*
            foreach (var t in args)
                s += t + ' ';
             * */
            int total = 22;//期刊总数
            /*
             * ACM COMPUT SURV
ACM T COMPUT SYST
ACM T SOFTW ENG METH
ARTIF INTELL
Automatica
Communications of The ACM
COMPUT CHEM
COMPUT INTELL
HUM-COMPUT INTERACT
IEEE T IMAGE PROCESS
IEEE T INFORM THEORY
IEEE T PATTERN ANAL
ieee transactions on communications
IEEE Transactions on Computers
IEEE Transactions on Neural Networks
IEEE Transactions on Signal Processing
ieee transactions on software engineering
J MACH LEARN RES
Journal of The ACM
MACH LEARN
Proceedings of The IEEE
THEOR PRACT LOG PROG
             * */
            string[] journalList = new string[total];
            journalList[0] = "ACM T COMPUT SYST";
            journalList[1] = "ACM COMPUT SURV";
            journalList[2] = "THEOR PRACT LOG PROG";
            journalList[3] = "ACM T SOFTW ENG METH";
            journalList[4] = "ARTIF INTELL";
            journalList[5] = "Automatica";//*****
            journalList[6] = "Communications of The ACM";
            journalList[7] = "COMPUT CHEM";
            journalList[8] = "COMPUT INTELL";
            journalList[9] = "HUM-COMPUT INTERACT";
            journalList[10] = "IEEE T IMAGE PROCESS";
            journalList[11] = "IEEE T INFORM THEORY";
            journalList[12] = "IEEE T PATTERN ANAL";
            journalList[13] = "ieee transactions on communications";
            journalList[14] = "IEEE Transactions on Computers";
            journalList[15] = "IEEE Transactions on Neural Networks";
            journalList[16] = "IEEE Transactions on Signal Processing";
            journalList[17] = "ieee transactions on software engineering";
            journalList[18] = "J MACH LEARN RES";
            journalList[19] = "Journal of The ACM";
            journalList[20] = "MACH LEARN";
            journalList[21] = "Proceedings of The IEEE";
            int cnt = 0;//已下载过的期刊数
            WokInterface w = new WokInterface();
            w.journalnickname = journalList[cnt].Replace(' ', '_');//"tse";
            
            if (w.authenticate())
            {
                System.Console.WriteLine("authenticated");
                int start = 1;
                WokSearchLiteService b = new WokSearchLiteService();
                int rdCnt = 0;//第n条记录
                while (cnt<total)
                {
                    string saveDir=@"C:\Users\LiuYibin\Documents\Visual Studio 2012\Projects\WOKWebService\WOKWebService\WOKWebService\records\"+w.journalnickname+@"\";
                    if (Directory.Exists(saveDir) == false) Directory.CreateDirectory(saveDir);
                    //retrieveParameters rp = new retrieveParameters();
                    //rp.count = count - start + 1 > 100 ? 100 : count - start + 1;
                    //rp.firstRecord = start;
                    //rp.sortField = null;
                    /*
                    var t = b.retrieve("1", rp);
                     * */
                    searchResults sr = w.searchByJournalName(w.journalnickname, start,100);
                    if (sr.records == null)
                    {
                        cnt++;
                        w.journalnickname = journalList[cnt];
                        start = 1;
                        rdCnt = 0;
                        continue;
                    }
                    w.reportProgress(start + 100 - 1,sr.recordsFound);//报告当前进度
                    //w.recorddata(sr, w.journalnickname + "_retrieve_" + start + "_" + (start + 100 - 1) + ".xml");
                    foreach(var record in sr.records)
                    {
                        //年份
                        
                        string year="0000";
                        foreach (var tmp in record.source)
                        {
                            if (tmp.label == "Published.BiblioYear")
                            {
                                year = tmp.value[0];
                                break;
                            }
                        }

                        //if (record.title[0].value[0] == "Speculative execution in a distributed file system") 
                        //year = "111";
                        
                        //建立文件夹和文件
                        //if (Directory.Exists(saveDir + year + @"\") == false) Directory.CreateDirectory(saveDir + year + @"\");
                        //StreamWriter sw = new StreamWriter(saveDir + year+@"\"+ rdCnt.ToString()+".txt");
                        StreamWriter sw = new StreamWriter(saveDir + year + ".txt", true);
                        rdCnt++;
                        //title
                        string title = "No title";
                        title = record.title[0].value[0];
                        sw.WriteLine("Title: " + title);
                        //DOI
                        string doi="No DOI";
                        foreach (var tmp in record.other)
                        {
                            if (tmp.label == "Identifier.Doi")
                            {
                                doi = tmp.value[0];
                                break;
                            }
                        }
                        if (doi == "No DOI")
                        {
                            foreach (var tmp in record.other)
                            {
                                if (tmp.label.Contains("Doi") || tmp.label.Contains("DOI"))
                                {
                                    doi = tmp.value[0];
                                    break;
                                }
                            }
                        }
                        if (doi == "No DOI") reportError(w.journalnickname + " " + year);
                        sw.WriteLine("DOI: "+doi);//doi号
                        //关键词
                        try
                        {
                            foreach (var s in record.keywords[0].value)
                            {
                                sw.WriteLine(s);//keywords
                            }
                        }
                        catch
                        {

                        }
                        sw.WriteLine("==============================");
                        sw.Close();
                    }
                    start += 100;
                    if (rdCnt >=sr.recordsFound)
                    {
                        cnt++;
                        w.journalnickname = journalList[cnt];
                        start=1;
                        rdCnt = 0;
                    }

                }
            }
            //int start = 1;
            /*                while (true)
                            {

                                //try
                                //{
            //                        retrieveParameters rp = new retrieveParameters();
            //                        rp.count = count - start + 1 > 100 ? 100 : count - start + 1;
            //                        rp.firstRecord = start;
            //                        rp.sortField = null;

            //                        var t = b.retrieve("1", rp);
                        
                                    //w.recorddata(t, journalnickname + "_retrieve_" + start + "_" + (start + 100 - 1) + ".xml");
                        
                                    var t = w.searchByJournalName(s, start, 100);
                                    w.recorddata(t, "test" + start + "_" + (start + 100 - 1) + ".xml");
                                    w.reportProgress(start + 100 - 1);
                        
                                    start += 100;
                                //}
                                //catch (Exception e)
                                //{
                                //    Console.WriteLine("exception e"+e.Message);
                                //    break;
                                //}
                            }
                            //w.retrieveRest();
                        }
                        else
                        {
                            System.Console.WriteLine("authentication failed");
                        }
                    }
                    /*static void Main(string[] args)
                    {
                        WOKMWSAuthenticateService a = new WOKMWSAuthenticateService();
                        string s = a.authenticate();
                        //System.Console.WriteLine(a.CookieContainer.Count);
                        System.Console.WriteLine("auth="+s);
                        WokSearchLiteService.WokSearchLiteService b = new WokSearchLiteService.WokSearchLiteService();
                        queryParameters q = new queryParameters();
                        q.databaseId = "WOK";
                        q.queryLanguage = "en";
                        //q.symbolicTimeSpan = "";
                        q.timeSpan = new timeSpan();
                        q.timeSpan.begin = "2001-01-01";
                        q.timeSpan.end = "2011-01-01";
                        q.userQuery = "SO = IEEE transactions on software engineering";
                        retrieveParameters r = new retrieveParameters();
                        r.sortField = null;
                        r.firstRecord = 1;
                        r.count = 5;
                        //b.CookieContain
                        b.CookieContainer = new System.Net.CookieContainer();
                        b.CookieContainer.Add(new Uri("http://search.webofknowledge.com/esti/wokmws/ws/WokSearchLite"),new Cookie("SID",s));
                        searchResults sr = b.search(q, r);
                        foreach (var i in sr.records)
                            System.Console.WriteLine("authors: " + i.authors);// + "" +i.keywords+ "" + "" + "");
                        System.Console.WriteLine(b.search(q,r));
                        //System.Console.WriteLine(//b.search(new queryParameters));
                    }*/

        }
    }
}