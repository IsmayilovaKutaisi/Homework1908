using System;
namespace Homework1908
{
	abstract class Figure
	{
		public abstract double CalcArea();
	}

	class Square:Figure
	{
		public double Side { get; set; }
        public override double CalcArea()
        {
            if(Side<=0)
			{
				Console.WriteLine("Side cannot be negative");
			}
			return Side * Side;
        }
    }

	class Rectangular:Figure
	{
		public double Width { get; set; }
		public double Length { get; set; }
        public override double CalcArea()
        {
            if(Width<=0&&Length<=0)
			{
				Console.WriteLine("Width and Length cannot be megative");
			}
			return Width * Length;
        }
    }
}

