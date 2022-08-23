using ImplementingQueueWithStacks;

var queue = new Queue(3);

queue.Enqueue(1);
queue.Enqueue(5);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();

queue.Enqueue(4);
queue.Enqueue(4);
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();


Console.WriteLine("--------------------------------------");

queue.Print();
