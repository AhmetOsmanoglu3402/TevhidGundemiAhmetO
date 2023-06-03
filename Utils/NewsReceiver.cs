using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TevhidGundemiMobile.Model;

namespace TevhidGundemiMobile.Utils
{
    public class NewsReceiver
    {
        public List<News> GetNews()
        {
            WebClient wClient = new WebClient();
            var rssNews = wClient.DownloadString("https://www.cnnturk.com/feed/rss/ekonomi/news");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(rssNews);
            var hotNews = new List<News>();
            for (var i = 0; i < xmlDocument.ChildNodes[1].ChildNodes[0].ChildNodes.Count; i++)
            {
                if (xmlDocument.ChildNodes[1].ChildNodes[0].ChildNodes[i].Name == "item")
                {
                    var haber = xmlDocument.ChildNodes[1].ChildNodes[0].ChildNodes[i].ChildNodes;
                    News n = new News();
                    n.Link = haber[1].InnerText;
                    n.Title = haber[2].InnerText;
                    var description = haber[3].InnerText;
                    if (description.Length > 100)
                    {
                        var boslukIndex = description.Substring(100, description.Length - 101).IndexOf(" ");
                        if (boslukIndex != -1)
                            description = description.Substring(0, boslukIndex + 100) + " ...";
                    }
                    n.Description = description;
                    n.PublishDate = haber[4].InnerText;//pubdate 10 saat önce gibi gösterilecek.
                    n.ImageURL =  haber[6].InnerText;
                    hotNews.Add(n);
                }
            }
            return hotNews;
        }

    }
}
