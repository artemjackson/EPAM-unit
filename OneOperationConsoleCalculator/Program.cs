using System;
using SimpleCalculator;

namespace OneOperationConsoleCalculator
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 4)
			{
				int x = Int32.Parse(args [1]);
				string op = args[2];
				int y = Int32.Parse (args [3]);
				
				var calculator = new Calculator<double>();

				try {
					var answ = calculator.PerformOperation(x, op, y);
					System.Console.WriteLine(answ);
				} catch (DivideByZeroException exc){
					System.Console.Write (exc.Message);
				}

			} else {
				System.Console.WriteLine ("Input requires 3 parameters: int1, operation, int2");
			}
		}
	}
}
