// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using LinqPriorityQueue;

PriorityQueue priorityQueue = new PriorityQueue();

priorityQueue.AddToQueue(2, "C");

priorityQueue.AddToQueue(1, "A");
priorityQueue.AddToQueue(1, "B");

System.Console.WriteLine(priorityQueue.Count());
//Console.WriteLine(priorityQueue.Extract());
//Console.WriteLine(priorityQueue.Extract());
//Console.WriteLine(priorityQueue.Extract());

foreach (string item in priorityQueue)
{
    System.Console.WriteLine(item);
}



