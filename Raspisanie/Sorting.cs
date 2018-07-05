using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Raspisanie
{
	class Sorting
	{
		public static void SortingByNumber(string[] stringArray) //тут вообще пиздец что происходит
		{
			int[] intArray = createIntArray(stringArray);
			BubbleSort(intArray, stringArray);
		}
		private static void BubbleSort(int[] intArray, string[] stringArray)
		{

			for (int i = 0; i < intArray.Length; i++)
				for (int j = 0; j < intArray.Length - 1; j++)
					if (intArray[j] > intArray[j + 1])
					{
						string t = stringArray[j + 1];
						stringArray[j + 1] = stringArray[j];
						stringArray[j] = t;
						int x = intArray[j + 1];
						intArray[j + 1] = intArray[j];
						intArray[j] = x;
					}
		}
		private static int[] createIntArray(string[] stringArray)
		{
			string pattern = @"\D";
			Regex regex = new Regex(pattern);
			int[] intArray = new int[stringArray.Length];
			for (int i = 0; i < stringArray.Length; i++)
			{
				string input = stringArray[i];
				string result = regex.Replace(input, "");
				intArray[i] = (result != "") ? intArray[i] = Int32.Parse(result) : intArray[i] = 0;
			}
			return intArray;
		}
	}
}

