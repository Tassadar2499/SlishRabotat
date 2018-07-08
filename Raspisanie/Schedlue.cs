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
		public List<double[]> schedlueWeights;

		public bool IsFreeAt(WeekDay day, int lessonNumber)
		{
			if (schedlue[(int)day][lessonNumber] == null)
				return false;
			return true;
		}

		public Schedlue()
		{
			var maxDay = 6;
			var maxSubjects = 7;

			schedlue = new List<Subject[]>(maxDay);
			schedlueWeights = new List<double[]>
			{
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, },
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, },
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, },
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, },
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, },
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, }
			};

			for (int day = 0; day < maxDay; day++)
				schedlue.Add(new Subject[maxSubjects]);
		}
	}
}
