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
				new double[]{43.2, 54.0, 50.4, 43.2, 36.0, 28.8, 21.6, 10.8 },
				new double[]{45.6, 57.0, 53.2, 45.6, 38.0, 30.4, 22.8, 11.4 },
				new double[]{51.8, 64.8, 60.5, 51.3, 43.2, 34.6, 26.0, 12.4 },
				new double[]{48.0, 60.0, 56.0, 48.0, 40.0, 32.0, 24.0, 12.0 },
				new double[]{42.0, 52.5, 49.0, 42.0, 35.0, 28.0, 21.0, 10.5 },
				new double[]{38.4, 48.0, 44.8, 38.4, 32.0, 25.6, 19.2, 9.6 }
			};
		}
	}
}
