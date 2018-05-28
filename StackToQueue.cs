using System;
using System.Collections.Generic;
using System.Linq;
					
public class CustomQueue
{
	Stack<int> s1 = new Stack<int>();
	Stack<int> s2 = new Stack<int>();
	
	public void Enqueue(int data)
	{
		while(s1.Any())
		{
			s2.Push(s1.Pop());
		}
		
		s1.Push(data);
		
		while(s2.Any())
		{
			s1.Push(s2.Pop());
		}
	}
	
	public int Dequeue()
	{
		if(s1 != null && s1.Any())
		{
			return s1.Pop();
		}
		else
		{
			throw new Exception("Error: Empty Queue");
		}
	}
}

public class Program
{	
	public static void Main()
	{
		Console.WriteLine("Stack to Queue...");
		
		var queue = new CustomQueue();
		
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);
		
		Console.WriteLine(queue.Dequeue());
		
		queue.Enqueue(4);
		queue.Enqueue(5);
		
		Console.WriteLine(queue.Dequeue());
		Console.WriteLine(queue.Dequeue());
		Console.WriteLine(queue.Dequeue());
		
		Console.ReadLine();		
	}
}