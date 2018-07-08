using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class SchoolClass
	{
		public string Name
		{
			get; set;
		}

		public Schedlue Schedlue
		{
			get; set;
		}

		public Dictionary<Subject, int> SubjectCountAtWeek
		{
			get; set;
		}

		public SchoolClass(string name, Dictionary<Subject, int> subjectCountAtWeek)
		{
			Name = name;
			Schedlue = new Schedlue();
			SubjectCountAtWeek = subjectCountAtWeek;
		}
	}
}
