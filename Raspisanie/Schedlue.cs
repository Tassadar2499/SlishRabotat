using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Schedlue
	{
		public const int MAX_DAY = 6;
		public List<Subject[]> schedlue;
		public List<double[]> schedlueWeights;
        public enum Days { Monday, Tuesday, Wenesday, Thursday, Friday, Saturday };

		public bool IsFreeAt(Days day, int lessonNumber)
		{
			return schedlue[(int)day][lessonNumber] == null;
		}

		public void PutLesson(Days day, int lesson, Subject subject)
		{
			schedlue[(int)day][lesson] = subject;
		}

		public void Reset()
		{
			schedlue = new List<Subject[]>();

			for (int day = 0; day < MAX_DAY; day++)
				schedlue.Add(new Subject[8]);
		}

		public Schedlue()
		{
			schedlue = new List<Subject[]>();

			for (int day = 0; day < MAX_DAY; day++)
				schedlue.Add(new Subject[8]);

			schedlueWeights = new List<double[]>
			{
				new double[]{43.2, 54.0, 50.4, 43.2, 36.0, 28.8, 21.6, 10.8 },
				new double[]{45.6, 57.0, 53.2, 45.6, 38.0, 30.4, 22.8, 11.4 },
				new double[]{57.6, 72.0, 67.2, 57.6, 48.0, 38.4, 28.8, 14.4 },
				new double[]{48.0, 60.0, 56.0, 48.0, 40.0, 32.0, 24.0, 12.0 },
				new double[]{42.0, 52.5, 49.0, 42.0, 35.0, 28.0, 21.0, 10.5 },
				new double[]{38.4, 48.0, 44.8, 38.4, 32.0, 25.6, 19.2, 9.6 }
			};
		}
	}
}
