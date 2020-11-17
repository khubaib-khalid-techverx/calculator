using System;

namespace Program
{
	class Program
	{

		public void addition()
		{
			Console.Write("Enter first number: ");
			double firstNumber = Convert.ToDouble((Console.ReadLine()));
			Console.Write("Enter second number: ");
			double secondNumber = Convert.ToDouble(Console.ReadLine());
			double result = firstNumber + secondNumber;
			Console.WriteLine("The addition of numbers " + firstNumber + " and " + secondNumber + " is " + result);
		}
		public void subtraction()
		{
			Console.Write("Enter first number: ");
			double firstNumber = Convert.ToDouble((Console.ReadLine()));
			Console.Write("Enter second number: ");
			double secondNumber = Convert.ToDouble(Console.ReadLine());
			double result = firstNumber - secondNumber;
			Console.WriteLine("The subtraction of numbers " + firstNumber + " and " + secondNumber + " is " + result);
			
		}
		public void multiplication()
		{
			Console.Write("Enter first number: ");
			double firstNumber = Convert.ToDouble((Console.ReadLine()));
			Console.Write("Enter second number: ");
			double secondNumber = Convert.ToDouble(Console.ReadLine());
			double result = firstNumber * secondNumber;
			Console.WriteLine("The multiplication of numbers " + firstNumber + " and " + secondNumber + " is " + result);
			
		}

		public void division()
		{
			Console.Write("Enter first number: ");
			double firstNumber = Convert.ToDouble((Console.ReadLine()));
			Console.Write("Enter second number: ");
			double secondNumber = Convert.ToDouble(Console.ReadLine());
			double result = firstNumber / secondNumber;
			Console.WriteLine("The division of numbers " + firstNumber + " and " + secondNumber + " is " + result);
			
		}
		

		static void Main(string[] args)
		{

			bool state = true;
			Program p = new Program();
			while (state != false)
			{
				Console.Write("Enter your operation : ");
				String operation = Console.ReadLine();
				

				switch (operation)
				{
					case "+":
						p.addition();
						break;
					case "-":
						p.subtraction();
						break;
					case "*":
						p.multiplication();
						break;
					case "/":
						p.division();
						break;
					default:
						Console.WriteLine("Wrong operation selected. Try Again!");
						break;

				}
				Console.WriteLine("Do you want to perform operation another time? Y/N");
				String choice = Console.ReadLine();
                if (choice == "Y" || choice == "y")
                {
					state = true;
                }
				else if (choice == "N" || choice == "n")
                {
					state = false;
                }
                else
                {
					Console.WriteLine("Wrong choice selected!");
                }

			}
		}


	}
}
