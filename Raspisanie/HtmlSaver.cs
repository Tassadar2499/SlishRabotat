using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Raspisanie
{
    static class HtmlSaver
    {
        public static string DIRECTORY = Assembly.GetExecutingAssembly().Location + "\\Table";
        public static void SaveToHTML(string labelText, Schedlue schedlue)
        {
            var htmlDocText = File.ReadAllText("TablePattern.html");

			var htmlDocBuilder= new StringBuilder();
            htmlDocBuilder.Append(htmlDocText);
            htmlDocBuilder.Replace("Title", labelText);
            htmlDocText = htmlDocBuilder.ToString();

			var subjects = new string[48];
            var iterator = 0;

			for (int lesson = 0; lesson < schedlue.maxLesson; lesson++)
            {
                for (var day = 0; day < schedlue.maxDay; day++)
                {
                    subjects[iterator] = schedlue.schedlue[day][lesson] != null
                        ? schedlue.schedlue[day][lesson].Name
                        : "-";
                    iterator++;
                }
            }

			var regex = new Regex(Regex.Escape("subject"));
			for (int i = 1; i <= subjects.Length; i++)
                htmlDocText = regex.Replace(htmlDocText, subjects[i-1], 1);
            
            File.AppendAllText(labelText + ".html", htmlDocText);
        }
    }
}
