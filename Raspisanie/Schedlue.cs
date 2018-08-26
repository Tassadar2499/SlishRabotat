using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Schedlue
	{
		public readonly int maxDay = 6;
		public readonly int maxLesson = 8;

		public List<Subject[]> schedlue;
		public List<double[]> schedlueWeights;

		public enum Day { Monday, Tuesday, Wenesday, Thursday, Friday, Saturday };

		public bool IsFreeAt(Day day, int lessonNumber)
		{
			return schedlue[(int)day][lessonNumber] == null;
		}

		public void PutLesson(Day day, int lesson, Subject subject)
		{
			schedlue[(int)day][lesson] = subject;
		}

		public void ClearSchedlue()
		{
			schedlue = new List<Subject[]>();

			for (int day = 0; day < maxDay; day++)
				schedlue.Add(new Subject[maxLesson]);
		}

		public Schedlue()
		{
			ClearSchedlue();

			schedlueWeights = new List<double[]>
			{
				new double[]{46.8, 50.4, 54.0, 46.8, 36.0, 21.6, 7.2, 1.8},
				new double[]{49.4, 53.2, 57.0, 49.4, 38.0, 22.8, 7.6, 1.9},
				new double[]{52.0, 56.0, 60.0, 52.0, 40.0, 24.0, 8.0, 2.0},
				new double[]{48.1, 51.8, 55.5, 48.1, 37.0, 22.2, 7.4, 1.9},
				new double[]{45.5, 49.0, 52.5, 45.5, 35.0, 21.0, 7.0, 1.8},
				new double[]{41.6, 44.8, 48.0, 41.6, 32.0, 19.2, 6.4, 1.6}
			};
		}
	}
}
