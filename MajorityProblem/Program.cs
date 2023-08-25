// See https://aka.ms/new-console-template for more information
using MajorityProblem;
using MajorityProblem.Helper;


var simpleSolution = new SimpleSolution();
var sortingSolution = new SortingSolution();
var mooreSoltuion = new MooreSolution();

int[] arrSorting = simpleSolution.generatArray(100000, 1, 100, 2);
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
