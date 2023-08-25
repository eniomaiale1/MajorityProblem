// See https://aka.ms/new-console-template for more information
using MajorityProblem;
using MajorityProblem.Helper;


var simpleSolution = new SimpleSolution();
var sortingSolution = new SortingSolution();
var mooreSoltuion = new MooreSolution();

int[] arrSorting = generatArray(100000, 1, 100, 2);
int[] arrMoore = (int[])arrSorting.Clone();
int[] arrSimple = (int[])arrSorting.Clone();

var watchSimpleSolution = System.Diagnostics.Stopwatch.StartNew();
var (simpleFound, simpleCount) = simpleSolution.mostFrequent(arrSimple, arrSimple.Length);
watchSimpleSolution.Stop();
var simpleSolutionTime = watchSimpleSolution.ElapsedMilliseconds;

var watchSortingSolution = System.Diagnostics.Stopwatch.StartNew();
var (sortingFound, sortingCount) = sortingSolution.mostFrequent(arrSorting, arrSorting.Length);
watchSortingSolution.Stop();
var sortingSolutionTime = watchSortingSolution.ElapsedMilliseconds;

var watchMooreSolution = System.Diagnostics.Stopwatch.StartNew();
var (mooreFound, mooreCount) = mooreSoltuion.mostFrequent(arrMoore, arrMoore.Length);
watchMooreSolution.Stop();
var mooreSolutionTime = watchMooreSolution.ElapsedMilliseconds;

Console.WriteLine($"Simple algorithm found the number {simpleFound} repeated {simpleCount} times and took {simpleSolutionTime} miliseconds");
Console.WriteLine($"Sorting algorithm found the number {sortingFound} repeated {sortingCount} times and took {sortingSolutionTime} miliseconds");
Console.WriteLine($"Moore's Voting algorithm found the number {mooreFound} repeated  {mooreCount}  times and took {mooreSolutionTime} miliseconds");
Console.ReadLine();
int[] generatArray(int n, int min, int max, int majority)
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