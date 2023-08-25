using MajorityProblem.Helper;
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

		public int[] generatArray(int n, int min, int max, int majority)
		{
			//This method generate an array of n integer elements where one of those elements will have the majority

			int nMinority = (int)Math.Floor(((double)n) / 2);
			int nMajority = (int)Math.Ceiling(((double)n) / 2);

			int Min = min;
			int Max = max;
			Random randNum = new Random();
			int[] arrMinority = Enumerable
				.Repeat(0, nMinority)
				.Select(i => randNum.Next(Min, Max))
				.ToArray();
			int[] arrMajority = Enumerable
						.Repeat(0, nMajority)
						.Select(i => majority)
						.ToArray();
			int[] arr = arrMinority.Concat(arrMajority).ToArray();
			var rng = new Random();
			rng.Shuffle(arr);
			return arr;

			//int[] arr = { 1,2,3,4,5,6,1,1,1,2,3,4,1 };
			//return arr;
		}
	}
}
