using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public static class SchedlueMaker
	{
		public static List<Grade> Grades
		{
			get;
			set;
		} = new List<Grade>();

		public static List<Teacher> Teachers
		{
			get;
			set;
		} = new List<Teacher>();

		static SchedlueMaker()
		{

		}

		public static Grade GetGradeByName(string name)
		{
			return Grades.Where(a => a.Name == name).FirstOrDefault();
		}

		public static Teacher GetOrCreateTeacherByName(string name)
		{
			if (Teachers.Select(a => a.Name).Contains(name))
				Teachers.Add(new Teacher(name));

			return Teachers.Where(a => a.Name == name).FirstOrDefault();
		}

		public static void ResetData()
		{
			foreach (var grade in Grades)
				grade.Reset();

			foreach (var teacher in Teachers)
				teacher.Reset();
		}


		//TODO:
		//Перепсать, чтобы не хранить учителей//классы, а получать готовые данные
		public static void CalculateSchedlue()
		{
			//Сбрасываем расписания
			ResetData();

			//предмет, у какого класса этот предмет
			var allSubjects = new List<Tuple<Subject, Grade>>();

			//берем все предметы всех классов
			foreach (var schoolClass in Grades)
				foreach (var subject in schoolClass.Subjects)
					allSubjects.Add(new Tuple<Subject, Grade>(subject.Key, schoolClass));

			//сортируем по убыванию
			allSubjects = allSubjects.OrderByDescending(a => a.Item1.Difficult).ToList();

			//пытаемся поставить предметы в расписание
			foreach (var subject in allSubjects)
			{
				//уроки в которые будем ставить предметы
				//день, урок, вес
				var allPlace = new List<Tuple<int, int, double>>();

				//берем все уроки
				for (var day = 0; day < subject.Item2.schedlueWeights.Count; day++)
					for (var lesson = 0; lesson < subject.Item2.schedlueWeights[day].Length; lesson++)
						allPlace.Add(new Tuple<int, int, double>
							(day, lesson, subject.Item2.schedlueWeights[day][lesson]));

				//сортируем по весам
				allPlace = allPlace.OrderByDescending(a => a.Item3).ToList();

				//ставим
				for (int i = 0; i < subject.Item1.CountAtWeek; i++)
				{
					foreach (var place in allPlace)
					{
						//если класс и препод свободен в этот момент
						var classIsFree = subject.Item2.IsFreeAt((Schedlue.Days)place.Item1, place.Item2);
						var teacherIsFree = subject.Item2.Subjects[subject.Item1].IsFreeAt((Schedlue.Days)place.Item1, place.Item2);

						if (classIsFree && teacherIsFree)
						{
							subject.Item2.PutLesson((Schedlue.Days)place.Item1, place.Item2, subject.Item1);
							subject.Item2.Subjects[subject.Item1].PutLesson((Schedlue.Days)place.Item1, place.Item2, subject.Item1);
							break;
						}
					}
				}
			}
		}
	}
}
