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

		private double CalculateWeightBonus(Grade grade, int day, int lesson)
		{
			if (grade.schedlue[day][lesson] == null)
				return 0;

			if (grade.schedlue[day][lesson] == this)
				return 0.09;
			else if (grade.Subjects[grade.schedlue[day][lesson]] == grade.Subjects[this])
				return 0.05;

			return 0;
		}

		private double GetNewWeight(Grade grade, int day, int lesson)
		{
			var repeatCount = 0;
			var weightBonus = 0.0;

			if (lesson >= 1)
				weightBonus += CalculateWeightBonus(grade, day, lesson - 1);
			
			if (lesson < grade.schedlue[day].Length - 2 && grade.schedlue[day][lesson + 1] == this)
				weightBonus += CalculateWeightBonus(grade, day, lesson + 1);

			foreach (var subject in grade.schedlue[day])
				if (subject == this)
					repeatCount++;

			return grade.schedlueWeights[day][lesson] * (1 - 0.25 * repeatCount + weightBonus);
		}

		public List<double[]> ReweightSchedlue(Grade grade)
		{
			var newSchedlueWeight = new List<double[]>();

			for (var day = 0; day < grade.schedlueWeights.Count; day++)
				newSchedlueWeight.Add(new double[grade.schedlueWeights[day].Length]);

			for (var day = 0; day < grade.schedlueWeights.Count; day++)
				for (var lesson = 0; lesson < grade.schedlueWeights[day].Length; lesson++)
					newSchedlueWeight[day][lesson] = GetNewWeight(grade, day, lesson);

			return newSchedlueWeight;
		}
	}
}
