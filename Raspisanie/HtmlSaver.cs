using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raspisanie
{
    class HtmlSaver
    {
        public static string DIRECTORY = Assembly.GetExecutingAssembly().Location + "\\Table";
        public static void saveToHTML(string labelText, Schedlue schedlue)
        {
            var htmlDocText = File.ReadAllText("TablePattern.html");
            StringBuilder htmlDocBuilder= new StringBuilder();
            htmlDocBuilder.Append(htmlDocText);
            htmlDocBuilder.Replace("Title", labelText);

            //File.AppendAllText(labelText + ".html", htmlDocBuilder.ToString());
        }
    }
}
