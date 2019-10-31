	// What will be the output of the following Code Snippet?
	
	class emp
	{
	    public string name;
	    public string address;
	    public void display()
	{
	        System.Console.WriteLine("{0} is in city {1}", name, address);
	}
	{
	       class Program
	}
	    static void Main(string[] args)
	{
	        emp obj = new emp();
	        obj.name = "Akshay";
	        obj.address = "new delhy";
	        obj.display();
	        Console.Readline();
	}
	}

// a.Syntax error
// b.  {0} is in city {1} Akshay new delhy
// c.Akshay is in new delhy
// d.Executes successfully and prints nothing
