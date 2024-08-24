using Homework1908;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Square");
            Console.WriteLine("2.Rectangular");
            Console.WriteLine("0.Quit");
            Console.WriteLine("Enter your choice");

            double choice = int.Parse.Console.ReadLine();
            switch (choice)
            {
                    case1:

            Console.WriteLine("Enter the value of the side of the square");
            double side = double.Parse(Console.ReadLine());
            var square = new Square { Side = side };
            Console.WriteLine($"Square area:{square.CalcArea}");
        case2:

            Console.WriteLine("Enter the value of the width of the Rectangular");
            double width = double.Parse(Console.ReadLine());
            var rectangular = new Rectangular(width = width);
            Console.WriteLine("Enter the value of the length of the rectangular");
            double.length = double.Parse(Console.ReadLine());
            var rectangular = new Rectangular(length = length);
            new Rectangular { width = width, Length = length };
            Console.WriteLine($"Rectangular area:{rectangular.CalcArea()}");
            break;

        case0:

            return;

            default:
                    Console.WriteLine("Wrong choice! Please make the right choice.");
            break;

        } } }

       
  
}

