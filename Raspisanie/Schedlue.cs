using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Schedlue
	{
		public enum WeekDay
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		public List<Subject[]> schedlue;

		public Schedlue()
		{
			var maxDay = 6;
			var maxSubjects = 7;

			schedlue = new List<Subject[]>();

			for (int day = 0; day < maxDay; day++)
				schedlue[day] = new Subject[maxSubjects];
		}
	}
}
