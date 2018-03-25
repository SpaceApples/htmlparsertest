using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlParserTest
{
    class Program
    {
        static void Main(string[] args)
        {
            String url = "https://www.swinburne.edu.au/study/courses/units/Object-Oriented-Programming-COS20007/local";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            string prerequisite = doc.DocumentNode.SelectSingleNode("//*[@id='content']/main/section[1]/div/div[3]/div[2]/a[1]").InnerText;

            Console.WriteLine(prerequisite);
        }
    }
}
