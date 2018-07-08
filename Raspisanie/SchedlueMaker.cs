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
		public static List<SchoolClass> SchoolClasses
		{
			get;
			set;
		} = new List<SchoolClass>();

		public static List<Teacher> Teachers
		{
			get;
			set;
		} = new List<Teacher>();

		static SchedlueMaker()
		{

		}

		private static IEnumerable<Teacher> LoadTeachers(string path)
		{
			var text = File.ReadAllText(path).Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var str in text)
				yield return new Teacher(str);
		}

		public static IEnumerable<SchoolClass> LoadClasses(string path)
		{
			var text = File.ReadAllText(path).Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (var str in text)
				yield return new SchoolClass(str, new Dictionary<Subject, int>());
		}

		public static IEnumerable<Subject> LoadSubjects(string path)
		{
			var text = File.ReadAllText(path).Split(new char[] { '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			for (var i = 0; i < text.Length; i++)
			{
				var str = text[i];
				var index = str.LastIndexOf('-');
				var subject = str.Substring(0, index);
				var difficult = str.Substring(index + 1);

				yield return new Subject(subject, Int32.Parse(difficult));
			}
		}

		public static void CalculateSchedlue()
		{
			var allSubjects = new List<Tuple<Subject, int, SchoolClass>>();

			foreach (var schoolClass in SchoolClasses)
				foreach (var subject in schoolClass.SubjectCountAtWeek)
					allSubjects.Add(new Tuple<Subject, int, SchoolClass>(subject.Key, subject.Value, schoolClass));

			allSubjects.OrderBy(a => a.Item1.Difficult);
			
			foreach (var subject in allSubjects)
			{
				var allPlace = new List<Tuple<DayOfWeek, int, int>>();

				for (var day = 0; day < subject.Item3.schedlue.Count; day++)
					for (var lesson = 0; lesson < subject.Item3.schedlue[day].Length; lesson++)
					{

					}
						
			}
		}
	}
}
