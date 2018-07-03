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
		public static IEnumerable<SchoolClass> GetClasses()
		{
			var text = File.ReadAllText("Classes.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var str in text)
				yield return new SchoolClass(str);
		}

		public static IEnumerable<Subject> GetSubjects()
		{
			var text = File.ReadAllText("Subjects.txt").Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				var difficult = str.Substring(index + 1);

				yield return new Subject(subject, Int32.Parse(difficult));
			}
		}
	}
}
