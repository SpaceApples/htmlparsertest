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
        static void pullingPrereqText()
        {
            List<string> prereqs = new List<string>();
            String url = "https://www.swinburne.edu.au/study/courses/units/Object-Oriented-Programming-COS20007/local";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            //loop through all nodes that match the xpath address
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//*[@id='content']/main/section[1]/div/div[3]/div[2]/a"))
            {
                //add the inner text between the open and end tags to prereqs
                prereqs.Add(node.InnerText);
            }
            //print out prereqs
            foreach (string element in prereqs)
            {
                Console.WriteLine(element);
            }
        }

        static void pullingUnitLinks()
        {
            List<string> links = new List<string>();
            String url = "https://www.swinburne.edu.au/study/course/bachelor-of-computer-science/software-development/";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);

            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//*[@id='course-structure-diagram']/div[1]/div[2]/div/table/tbody/tr/td[1]/a[@href]"))
            {
                if (node != null) {
                    links.Add(node.Attributes["href"].Value);
                }
            }

            foreach (string element in links)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            pullingPrereqText();
            pullingUnitLinks();
        }
    }
}
