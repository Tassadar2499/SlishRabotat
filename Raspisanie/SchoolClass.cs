using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class SchoolClass : Schedlue
	{
		public string Name
		{
			get;
			set;
		}

		public Dictionary<Subject, Tuple<int, Teacher>> SubjectSetting
		{
			get;
			set;
		} = new Dictionary<Subject, Tuple<int, Teacher>>();

		public void AddSubject(Subject subject, int countLessenPerWeek, Teacher teacher)
			=> SubjectSetting.Add(subject, new Tuple<int, Teacher>(countLessenPerWeek, teacher));

		public SchoolClass(string name)
		{
			Name = name;
		}
	}
}
