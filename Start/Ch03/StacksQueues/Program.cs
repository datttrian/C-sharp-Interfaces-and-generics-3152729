﻿// Create a new stack to hold the names of sports
Stack<string> sportsStack = new();
// Push some initial items on to the stack
sportsStack.Push("Baseball");
sportsStack.Push("Football");
sportsStack.Push("Cricket");
sportsStack.Push("Basketball");
sportsStack.Push("Hockey");
sportsStack.Push("Rugby");

// TODO: Let's see how many items are on the stack
Console.WriteLine($"There are {sportsStack.Count} in the stack");

// TODO: Peek at the top item
Console.WriteLine($"The top item is {sportsStack.Peek()}");

// TODO: Pop 2 items, then try the Contains method
sportsStack.Pop();
sportsStack.Pop();
Console.WriteLine($"Stack contains Hockey: {sportsStack.Contains("Hockey")}");

// Create a queue to hold the names of sports
Queue<string> sportsQueue = new();
// Enqueue some initial items on to the stack
sportsQueue.Enqueue("Baseball");
sportsQueue.Enqueue("Football");
sportsQueue.Enqueue("Cricket");
sportsQueue.Enqueue("Basketball");
sportsQueue.Enqueue("Hockey");
sportsQueue.Enqueue("Rugby");

// TODO: Let's see how many items are on the queue
Console.WriteLine($"There are {sportsQueue.Count} in the stack");

// TODO: Peek at the front item
Console.WriteLine($"The top item is {sportsQueue.Peek()}");

// TODO: Dequeue 2 items, then try the Contains method
sportsQueue.Dequeue();
sportsQueue.Dequeue();
Console.WriteLine($"Queue contains Hockey: {sportsStack.Contains("Hockey")}");
