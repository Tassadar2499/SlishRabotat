using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public static class SchedlueMaker
	{
		public static string[] GetClasses()
		{
			return File.ReadAllText("Classes.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		}

		public static Dictionary<string, int> GetSubjects()
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			var dictionary = new Dictionary<string, int>();

			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				var difficult = str.Substring(index + 1);
				dictionary.Add(subject, Int32.Parse(difficult));
			}

			return dictionary;
		}
	}
}
