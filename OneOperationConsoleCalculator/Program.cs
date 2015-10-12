using System;
using SimpleCalculator;

namespace OneOperationConsoleCalculator
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length == 3)
			{
				try {
					int x = Int32.Parse(args [0]);
					int y = Int32.Parse (args [2]);
				} catch (FormatException exc){
					System.Console.WriteLine("Invalid input parameters type. Parameters should be integers");
				}
				string op = args[1];

				var calculator = new Calculator<int>();

				try {
					var answ = calculator.PerformOperation(x, op, y);
					System.Console.WriteLine(answ);
				} catch (DivideByZeroException exc){
					System.Console.Write (exc.Message);
				} catch (UnknownOperationException exc) {
					System.Console.Write (exc.Message);
				}

			} else {
				System.Console.WriteLine ("Invalid nuber of input parameters. Input requires 3 parameters: int1, operation, int2");
			}
		}
	}
}
