using Strategy;
using Strategy.ConcreteStrategies;
using Strategy.Context;
using System.Diagnostics;

const int n = 20000;
var data = new int[n];
for (var i = 0; i < data.Length; i++)
    data[i] = new Random().Next(n);

var bubbleArray = data.Select(x => x).ToArray();
var quickArrayLomuto = data.Select(x => x).ToArray();
var quickArrayHoare = data.Select(x => x).ToArray();
var arrSys = data.Select(x => x).ToArray();

var bubbleSort = new BubbleSort();
var quickSortLomuto = new QuickSortLomuto();
var quickSortHoare = new QuickSortHoare();

var sortContext = new SortingMethod(bubbleSort);
var stopwatch = Stopwatch.StartNew();
sortContext.SortContext(bubbleArray);
stopwatch.Stop();
Console.WriteLine($"Bubble Sort executed in: {stopwatch.GetTimeString()}");

sortContext.SetSortStrategy(quickSortLomuto);
stopwatch = Stopwatch.StartNew();
sortContext.SortContext(quickArrayLomuto);
stopwatch.Stop();
Console.WriteLine($"Quick Sort Lomuto executed in: {stopwatch.GetTimeString()}");

sortContext.SetSortStrategy(quickSortHoare);
stopwatch = Stopwatch.StartNew();
sortContext.SortContext(quickArrayHoare);
Console.WriteLine($"Quick Sort Hoare executed in: {stopwatch.GetTimeString()}");
stopwatch.Stop();
