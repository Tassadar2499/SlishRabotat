using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Subject
	{
		public string Name
		{
			get; set;
		}

		public int Difficult
		{
			get; set;
		}

		public int CountAtWeek
		{
			get; set;
		}

		public Subject(string name, int difficult, int countAtWeek)
		{
			Name = name;
			Difficult = difficult;
			CountAtWeek = countAtWeek;
		}
	}
}
