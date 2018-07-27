using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Schedlue
	{
		public List<Subject[]> schedlue;
		public List<double[]> schedlueWeights;

		public bool IsFreeAt(DayOfWeek day, int lessonNumber)
		{
			return schedlue[(int)day][lessonNumber] == null;
		}

		public void PutLesson(DayOfWeek day, int lesson, Subject subject)
		{
			schedlue[(int)day][lesson] = subject;
		}

		public Schedlue()
		{
			var maxDay = 6;
			//var maxLesson = 7;

			schedlue = new List<Subject[]>();

			for (int day = 0; day < maxDay; day++)
				schedlue.Add(new Subject[7]);

			schedlueWeights = new List<double[]>
			{
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0},
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0},
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0},
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0},
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0},
				new double[]{1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0}
			};
		}
	}
}
