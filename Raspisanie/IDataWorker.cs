using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raspisanie
{
	public interface IDataWorker
	{
		Dictionary<string, int> GetSubjects();
		string[] GetClasses();
	}
}
