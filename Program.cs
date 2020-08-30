
using System;
using System.IO;
using System.Text;
using System.Transactions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Collections.Generic;

namespace _11_5_Lab_dB_2_C_2HTML
{   
    //classes etc for creating html files will be found here.
    class myHTML
    {
        public const string htmlPager = @"<!DOCTYPE html>";
        public const string htmlDocOpen = "<html>";
        public const string htmlDocClose = "</html>";

        public const string headOpen = "<head>";
        public const string headClose = "</head>";

        public const string bodyOpen = "<body>";
        public const string bodyClose = "</body>";

        public string StartHtml()
        {
            string startHtml = String.Concat(htmlPager, "\n", htmlDocOpen, "\n", headOpen);
            return startHtml;
        }
        public string StartBody()
        {
            string startbody = String.Concat(headClose, "\n", bodyOpen);
            return startbody;
        }
        public string EndHtml()
        {
            string endHtml = String.Concat(bodyClose, "\n", htmlDocClose);
            return endHtml;
        }

    }

    class HtmlTitle
    {
        public const string open = "<title>";
        public const string close = "</title>";

        public string CreateHtmlTitler(string text)
        {
            string title = String.Concat(open, text, close, "\n");
            return title;
        }
    }

    class Header
    {
        public const string open = "<h1>";
        public const string close = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(open, text, close, "\n");
            return header;
        }
    }

    class UnorderedList
    {
        public const string open = "<ul>";
        public const string close = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(open);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(close);

            return sb;
        }

    }
    //Here is sample code for use in Main() w/ the above classes
    /*
            string filename = "C://weblogs//9_4Lab.html";
            StringBuilder myHtmlPage = new StringBuilder();

            HtmlTitle htmlTitle = new HtmlTitle();
            Console.WriteLine("Enter text for HTML title.");
            string HtmlTitle = htmlTitle.CreateHtmlTitler(Console.ReadLine()); 
            myHtmlPage.Append(htmlTitle);   
            
            Header header = new Header();
            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());            
            myHtmlPage.Append(headerElement);
    
            UnorderedList list = new UnorderedList();
            string[] listItems = new string[3];
            for (int i = 0; i < listItems.Length; i++)
                {
                    Console.WriteLine("Add another item to the list.");
                    listItems[i] = list.CreateListItem(Console.ReadLine());
                }
            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());     
     */
    class Program
    {
        static void Main(string[] args)
        {
            SakilaContext context = new SakilaContext();
            //Add some records to the film table
            SakilaFilmTable newFilm1 = new SakilaFilmTable("1917", "War Drama by Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            context.SakilaFilmTable.Add(newFilm1);
            //context.SaveChanges();
            SakilaFilmTable newFilm2 = new SakilaFilmTable("Joker", "Oscar - Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            context.SakilaFilmTable.Add(newFilm2);
            //context.SaveChanges();
            SakilaFilmTable newFilm3 = new SakilaFilmTable("Star Wars: The Rise of Skywalker", "Trash Disney Fan - fic", "2019", 3, 4.99m, 202, 21.99m, "PG - 13");
            context.SakilaFilmTable.Add(newFilm3);
            context.SaveChanges();

            SakilaFilmTable[] allFilms = context.SakilaFilmTable.ToArray();

            //var newfilms = allfilms.Where(x => x.release_year == "2019");
            List<SakilaFilmTable> linqList = (from f in allFilms
                        where f.release_year == "2019"
                        select f).ToList();

            string filename = @"d:\AppClass\11_5_Lab.html";
            StringBuilder myHtmlPage = new StringBuilder();

            myHTML docOutline = new myHTML();
            docOutline.StartHtml();
            myHtmlPage.Append(docOutline);

            HtmlTitle htmlTitle = new HtmlTitle();
            htmlTitle.CreateHtmlTitler("Sakila New Films");
            myHtmlPage.Append(htmlTitle);

            docOutline.StartBody();
            myHtmlPage.Append(docOutline);

            Header header = new Header();
            header.CreateHeader("New Films Coming Soon");
            myHtmlPage.Append(header);

            UnorderedList list = new UnorderedList();
            string[] listItems = new string[3];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }
            StringBuilder listElement = list.CreateList(listItems);
            myHtmlPage.Append(listElement.ToString());

            docOutline.EndHtml();
            myHtmlPage.Append(docOutline);

            File.AppendAllText(filename, myHtmlPage.ToString());

        }
    }
}
