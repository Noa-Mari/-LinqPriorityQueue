// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using LinqPriorityQueue;

PriorityQueue priorityQueue = new PriorityQueue();

priorityQueue.AddToQueue(2, "C");

priorityQueue.AddToQueue(1, "A");
priorityQueue.AddToQueue(1, "B");


Console.WriteLine(priorityQueue.Extract());
Console.WriteLine(priorityQueue.Extract());
Console.WriteLine(priorityQueue.Extract());



