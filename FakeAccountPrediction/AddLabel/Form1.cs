using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support;
using System.Text.RegularExpressions;

namespace AddLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromeDriver driver;
        
        Thread a;
        double label;
        public void WorkingThread()
        {
            try
            {
                System.IO.File.AppendAllText("log.txt", "khoi dong" + DateTime.Now+"\r\n");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
                var options = new ChromeOptions();
                options.AddArgument("--disable-notifications");
                //options.AddArgument("--headless");
                //options.AddArgument("--window-position=-32000,-32000");
                driver = new ChromeDriver(service, options);

               
                if (LoginCB.Checked)
                {
                    driver.Navigate().GoToUrl(LoginURLTB.Text);
                    driver.FindElementByXPath(XIDTB.Text).SendKeys(IDTB.Text);
                    driver.FindElementByXPath(XPassTB.Text).SendKeys(PassTB.Text);
                    driver.FindElementByXPath(LoginXpathTB.Text).Click();
                    System.IO.File.AppendAllText("log.txt", "login" + DateTime.Now + "\r\n");
                }
                else
                {
                    Regex r = new Regex(@"c_user=(.+?);xs=(.+?);fr=(.+)");
                    Match m = r.Match(System.IO.File.ReadAllText("cookie.txt").Replace("\r\n",""));
                    driver.Navigate().GoToUrl(LoginURLTB.Text);
                    Cookie c_user = new Cookie("c_user", m.Groups[1].Value);
                    Cookie xs = new Cookie("xs", m.Groups[2].Value);
                    Cookie fr = new Cookie("fr", m.Groups[3].Value);
                    driver.Manage().Cookies.AddCookie(c_user);
                    driver.Manage().Cookies.AddCookie(xs);
                    driver.Manage().Cookies.AddCookie(fr);
                }
                System.IO.StreamReader rd = new System.IO.StreamReader("ids.txt");
                while(!rd.EndOfStream)
                {
                    string id = rd.ReadLine();
                    label = -1;
                    

                    double[] result = getVector(id);
                    string s = result[0].ToString() + " " + result[1].ToString() + " "
                        + result[2].ToString() + " " + result[3].ToString() + " " + result[4].ToString() + " " + result[5].ToString() + " " + result[6].ToString() + " "
                        + result[7].ToString() + " " + result[8].ToString() + " " + result[9].ToString() + " " + result[10].ToString() + " " + result[11].ToString();
                    log(id+" : "+s);
                    driver.Navigate().GoToUrl("https://www.facebook.com/" + id);
                    while (label == -1)
                    {
                        Thread.Sleep(1000);
                    }
                    System.IO.File.AppendAllText("log.txt", "done "+id +s+" "+ DateTime.Now + "\r\n");
                    System.IO.File.AppendAllText("result.txt", s + " " + label.ToString() + "\r\n");
                }
                

                driver.Dispose();
                
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
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

                
                ProcessLB.Text = text+ "\r\n" + ProcessLB.Text;
                
            }
        }
        private void RealBTN_Click(object sender, EventArgs e)
        {
            label = 1;
        }

        private void FakeBTN_Click(object sender, EventArgs e)
        {
            label = 0;
        }

        private void UnknowBTN_Click(object sender, EventArgs e)
        {
            label = 0.5;
        }
        public double[] getVector(string id)
        {

            int _maxsleep = (int)SleepingNUD.Value;
            int NumberOfPictures = 0;
            double LikePerPicture = 0;
            int NumberOfPicturesOf = 0;
            double LikePerPictureOf = 0;
            int NumberOfVideosBy = 0;
            int NumberOfVideosTagged = 0;
            int NumberOfPosts = 0;
            int NumberOfPostsTagged = 0;
            int NumberOfPlaces = 0;
            int NumberOfPlacesLiked = 0;
            int NumberOfFriends = 0;
            int NumberOfGroup = 0;
            ICollection<IWebElement> elements;


            #region photo by
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/photos-by");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@data-fbid and @data-bt]"));
                NumberOfPictures = driver.FindElementsByXPath(@"//img[@class='scaledImageFitHeight img']").Count;
                foreach (IWebElement e in elements)
                {
                    try
                    {
                        string slike = e.FindElement(By.XPath(@".//span[1]/a/div/div[1]/div[2]")).Text;
                        if (slike.Last() != 'K')
                        {
                            int ilike = Convert.ToInt32(slike);
                            LikePerPicture += ilike;
                        }
                        else
                        {
                            slike.Remove(slike.Length - 1);
                            double dlike = Convert.ToDouble(slike);
                            dlike = dlike * 1000;
                            LikePerPicture += dlike;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("log.txt", ex.Message + DateTime.Now + "\r\n");
                    }

                }
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }

            #endregion
            #region photo of
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/photos-of");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@data-fbid and @data-bt]"));
                NumberOfPicturesOf = driver.FindElementsByXPath(@"//img[@class='scaledImageFitHeight img']").Count;
                foreach (IWebElement e in elements)
                {
                    try
                    {
                        string slike = e.FindElement(By.XPath(@".//span[1]/a/div/div[1]/div[2]")).Text;
                        if (slike.Last() != 'K')
                        {
                            int ilike = Convert.ToInt32(slike);
                            LikePerPictureOf += ilike;
                        }
                        else
                        {
                            slike.Remove(slike.Length - 1);
                            double dlike = Convert.ToDouble(slike);
                            dlike = dlike * 1000;
                            LikePerPictureOf += dlike;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("log.txt", ex.Message + DateTime.Now + "\r\n");
                    }

                }
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }

            #endregion
            #region video by
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/videos-by");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@class='_401d']"));
                NumberOfVideosBy = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion

            #region video tagged
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/videos-of/intersect");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@class='_401d']"));
                NumberOfVideosTagged = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion

            #region post by
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/stories-by");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@class='_401d']"));
                NumberOfPosts = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion

            #region post tag
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/stories-tagged/intersect");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@class='_401d']"));
                NumberOfPostsTagged = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion

            #region places visited
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/places-visited");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//li[@id and @data-bt]"));
                NumberOfPlaces = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion
            #region places liked
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/places-liked");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//li[@id and @data-bt]"));
                NumberOfPlacesLiked = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion
            #region friends
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/" + id );
                string xpath = @"//a[contains(@href,'" + driver.Url + "') and contains(@href,'friends') and text()]";
                for (int i = 0; i < _maxsleep ; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements= driver.FindElementsByXPath(xpath);
                string text = elements.Last().Text.Replace(".","");
                NumberOfFriends = Convert.ToInt16(text);

            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }
            #endregion
            #region groups
            try
            {
                driver.Navigate().GoToUrl("https://www.facebook.com/search/" + id + @"/groups");
                for (int i = 0; i < _maxsleep; i++)
                {
                    ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,200)");
                    Thread.Sleep(1000);
                }
                elements = driver.FindElements(By.XPath(@".//div[@class='_401d']"));
                NumberOfGroup = elements.Count;
            }
            catch (Exception e)
            {
                System.IO.File.AppendAllText("log.txt", e.Message + DateTime.Now + "\r\n");
            }

            #endregion

            double[] d=new double[12];
            d[0]= NumberOfPictures;
            d[1]= LikePerPicture;
            d[2]= NumberOfPicturesOf;
            d[3]= LikePerPictureOf;
            d[4]= NumberOfVideosBy;
            d[5]= NumberOfVideosTagged;
            d[6]= NumberOfPosts;
            d[7]= NumberOfPostsTagged;
            d[8]= NumberOfPlaces;
            d[9]= NumberOfPlacesLiked;
            d[10]=  NumberOfFriends;
            d[11]= NumberOfGroup;
            return d;

        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            a = new Thread(WorkingThread);
            a.Start();
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            a.Abort();
            driver.Dispose();
            
        }
    }
}
