using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GetIdFB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread a;
        private void GetIDBTN_Click(object sender, EventArgs e)
        {
            a = new Thread(start);
            a.Start();
        }
        public string getID(string url)
        {
            var client = new RestClient("https://stalkscan.com/get-fb-id.php");
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "c251e0fc-f237-cd94-c062-eeb0db0b9b88");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("referer", "https://stalkscan.com/");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("x-requested-with", "XMLHttpRequest");
            request.AddHeader("origin", "https://stalkscan.com");
            request.AddHeader("accept", "*/*");
            request.AddParameter("application/x-www-form-urlencoded", "url=" + HttpUtility.UrlEncode(url), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Regex r = new Regex("\"id\":\"(.+?)\"");
            Match m = r.Match(HttpUtility.HtmlDecode(response.Content));
            return m.Groups[1].Value;
        }

        public void start()
        {
            foreach (string url in InputRTB.Lines)
            {
                process = 0;
                TaskInfo t = new TaskInfo(url);
                ThreadPool.SetMaxThreads((int)MaxThreadNUD.Value, (int)MaxThreadNUD.Value);
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc), t);
                //Thread x = new Thread(() => 
                //{
                //    LibOfThorn.Seo.Crawler.Crawl(url, Xpaths, @"result\" + url.Replace(".", "-").Replace(@"https://","").Replace(@"http://", "").Replace("/", "-") + ".txt");
                //    log(url+" => OK");
                //});
                //x.Start();
            }
        }
        delegate void SetTextCallback(string text);
        private void log(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ProcessLB.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(log);
                this.Invoke(d, new object[] { text });
            }
            else
            {
               
                process++;
                ProcessLB.Text = process.ToString();
                System.IO.File.AppendAllText("log.txt", text + "\r\n");
            }
        }
        int process = 0;
        void ThreadProc(Object stateInfo)
        {
            TaskInfo ti = (TaskInfo)stateInfo;
            log(getID(ti.url));
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            a.Abort();
        }
    }
    public class TaskInfo
    {
        // State information for the task.  These members
        // can be implemented as read-only properties, read/write
        // properties with validation, and so on, as required.
        public string url;

        // Public constructor provides an easy way to supply all
        // the information needed for the task.
        public TaskInfo(string _URL)
        {
            url = _URL;
            
        }
    }
}
