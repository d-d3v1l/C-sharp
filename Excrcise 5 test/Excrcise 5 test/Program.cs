// 5.	What will be the output of the following Code Snippet?

6.	using System;
7.	class sample
8.	{
9.	    public static void first()
10.	    {
11.	        Console.WriteLine("first method");
12.	    }
13.	
14.	    public void second()
15.	    {
16.	        Console.WriteLine(i);
17.	        second();
18.	    }
19.	}  
20.	        {
21.	        class program
22.	        
23.	        }
24.	     
25.	        public static void Main()
26.	        {
27.	    sample obj = new sample();
28.	    sample.first();
29.	    obj.second(10);
30.	    }
31.	}

// a.Second method
// 10
// Second method
// First method
// b.First method
// 10
// First method
// Second method
// c.first method
// 10
// d.second method
// 10
// First method
