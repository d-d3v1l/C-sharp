class A
{
    static void Main(string[] arg)
    {

        vegetable krastavica = new vegetable("krastavica");

        Console.WriteLine(krastavica);

        Console.WriteLine(krastavica.ToString());

        Food pol = new vegetable("domat");

        Console.WriteLine(pol.ToString());

        pol.prepareFood();

        Food pol2 = new Fruit("Praskova");

        Console.WriteLine(pol2.ToString());

        pol2.prepareFood();

        Fruit f2 = new Fruit("Kaisia");

        LinkedList<Food> foods = new LinkedList<Food>();

        foods.AddList(krastavica);

        foods.AddList(pol);

        foods.AddList(pol2);

        foods.AddList(f2);


    }

}
