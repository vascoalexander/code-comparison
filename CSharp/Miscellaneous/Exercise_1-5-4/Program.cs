// Exercise 1-5-4
// the stopwatch format is hours:minuts:seconds.milliseconds
using System.Diagnostics;

Stopwatch stopWatch = Stopwatch.StartNew();
stopWatch.Start();

int sum = 0;
for (int i = 0; i < 20000; i++)
{
    sum += i * 8;
    Console.WriteLine(sum);
}

stopWatch.Stop();
string elapsedTime = stopWatch.Elapsed.ToString();
Console.WriteLine(elapsedTime);
