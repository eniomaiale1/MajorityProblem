using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityProblem
{
	abstract class MajorityProblem
	{
        public abstract (int, int) mostFrequent(int[] arr, int n);

		//public int[] generatArray(int n, int min, int max) {
		//	int Min = min;
		//	int Max = max;
		//	Random randNum = new Random();
		//	int[] arr = Enumerable
		//		.Repeat(0, n)
		//		.Select(i => randNum.Next(Min, Max))
		//		.ToArray();
		//	return arr;
		//}
    }
}
