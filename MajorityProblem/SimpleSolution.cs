using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityProblem
{
	internal class SimpleSolution : MajorityProblem
	{
		public override (int, int) mostFrequent(int[] arr, int n)
		{
			int maxcount = 0;
			int element_having_max_freq = 0;
			for (int i = 0; i < n; i++)
			{
				int count = 0;
				for (int j = 0; j < n; j++)
				{
					if (arr[i] == arr[j])
					{
						count++;
					}
				}

				if (count > maxcount)
				{
					maxcount = count;
					element_having_max_freq = arr[i];
				}
			}

			return (element_having_max_freq, maxcount);
		}
	}
}
