using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Teacher : Schedlue
	{
		public string Name
		{
			get; set;
		}

		public Teacher(string name)
		{
			Name = name;
		}
	}
}
