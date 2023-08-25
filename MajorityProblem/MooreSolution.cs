using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityProblem
{
	internal class MooreSolution : MajorityProblem
	{
		public int maxFreq(int[] arr, int n)
		{

			int resultIndex = 0;
			int count = 1;
			for (int i = 1; i < n; i++)
			{
				if (arr[i] == arr[resultIndex])
				{
					count++;
				}
				else
				{
					count--;
				}

				if (count == 0)
				{
					resultIndex = i;
					count = 1;
				}

			}

			return arr[resultIndex];
		}
		public override (int, int) mostFrequent(int[] arr, int n)
		{

			int freq = maxFreq(arr, n);
			int count = 0;
			for (int i = 0; i < n; i++)
			{
				if (arr[i] == freq)
				{
					count++;
				}
			}
			
			if(count > (n/2))
				return (freq, count);
			return (-1, 0);
		}
	}
}
