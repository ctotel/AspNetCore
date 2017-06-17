using System;

namespace Video1
{
    class Program
    {
        static void Main(string[] args)
        {   string name;
		
            Console.WriteLine("Hello World!");
			
			name = Console.ReadLine();
			  // C# 7
			Console.WriteLine ($"Hello {name}");
			Console.WriteLine ("Hello2 " +name);
			
        }
    }
}
