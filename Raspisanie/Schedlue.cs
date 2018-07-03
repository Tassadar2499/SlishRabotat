using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	class Schedlue
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

		public Schedlue(int[] subjectsCountAtDay)
		{
			if (subjectsCountAtDay.Length != 7)
				throw new ArgumentException("subjectsCountAtDay.Lenght must be 7");

			schedlue = new List<Subject[]>();

			for (int day = 0; day < subjectsCountAtDay.Length; day++)
				schedlue[day] = new Subject[subjectsCountAtDay[day]];
		}
	}
}
