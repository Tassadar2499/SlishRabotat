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

		public Subject(string name, int difficult)
		{
			Name = name;
			Difficult = difficult;
		}
	}
}
