using Abstract_clas;

MaxHeap heap = new MaxHeap();
heap.Insert(1);
heap.Insert(2);
heap.Insert(3);
heap.Insert(4);
heap.Insert(5);

MinHeap heap1 = new MinHeap();
heap1.Insert(1);
heap1.Insert(2);
heap1.Insert(3);
heap1.Insert(4);
heap1.Insert(5);

Console.WriteLine($"{heap.Extact()}");
Console.WriteLine($"{heap1.Extact()}");


