using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Raspisanie
{
	public class SortingStringByNumber : IComparer<string>
	{
		private int GetNumber(string str)
		{
			var num = string.Join("", str.TakeWhile(a => Char.IsNumber(a)).ToArray());

			if (num == "")
				return int.MaxValue;

			return int.Parse(num);
		}


		public int Compare(string x, string y)
		{
			var number1 = GetNumber(x);
			var number2 = GetNumber(y);

			if (number1 == number2)
				return x.CompareTo(y);

			return number1.CompareTo(number2);
		}
	}
}

