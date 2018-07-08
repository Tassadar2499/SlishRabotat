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

		public Dictionary<Subject, Teacher> Subjects
		{
			get;
			set;
		} = new Dictionary<Subject, Teacher>();

		public void AddSubject(Subject subject, Teacher teacher)
			=> Subjects.Add(subject, teacher);

		public SchoolClass(string name)
		{
			Name = name;
		}
	}
}
