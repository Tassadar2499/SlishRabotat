using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class Subject : IEquatable<Subject>
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

		public Subject(string name, int difficult, int countAtWeek = 0)
		{
			Name = name;
			Difficult = difficult;
			CountAtWeek = countAtWeek;
		}

		public bool Equals(Subject other)
		{
			return Name == other.Name && Difficult == other.Difficult && CountAtWeek == other.CountAtWeek;
		}

		public double GetNewWeight(Schedlue schedlue, int day, int lesson)
		{
			var repeatCount = 0;
			var weightBonus = 0.0;

			foreach (var subject in schedlue.schedlue[day])
				if (subject == this)
					repeatCount++;

			if (lesson > 0 && schedlue.schedlue[day][lesson - 1] == this)
				weightBonus += 0.01;
			
			if (lesson < schedlue.schedlue[day].Length - 2 && schedlue.schedlue[day][lesson + 1] == this)
				weightBonus += 0.01;

			return schedlue.schedlueWeights[day][lesson] * (1 - 0.2 * repeatCount + weightBonus);
		}

		public List<double[]> ReweightSchedlue(Schedlue schedlue)
		{
			var newSchedlueWeight = new List<double[]>();

			for (var day = 0; day < schedlue.schedlueWeights.Count; day++)
				newSchedlueWeight.Add(new double[schedlue.schedlueWeights[day].Length]);

			for (var day = 0; day < schedlue.schedlueWeights.Count; day++)
				for (var lesson = 0; lesson < schedlue.schedlueWeights[day].Length; lesson++)
					newSchedlueWeight[day][lesson] = GetNewWeight(schedlue, day, lesson);

			return newSchedlueWeight;
		}
	}
}
