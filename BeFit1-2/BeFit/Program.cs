
using BeFit;



TaskHandler taskHandler = new TaskHandler();
taskHandler.AddTask(() =>
{
    Console.WriteLine("Run task 1");
    Thread.Sleep(1000);
});
taskHandler.AddTask(() =>
{
    Console.WriteLine("Run task 2");
    Thread.Sleep(1000);
});
taskHandler.BeginInvoke();
Thread.Sleep(500);
Console.WriteLine("Main thread");
await taskHandler.EndInvoke();
Console.WriteLine("taskHandler ended");


IEnumerable<double> row = Enumerable.Range(1, 5).Select(i => (double)i);
IEnumerable<double> rowSums = RowSumer.GetRowSums(row);

Console.WriteLine(string.Join(", ", rowSums));