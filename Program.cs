using System.Security.Cryptography.X509Certificates;

namespace Dele_0729
{
	internal class Program
	{
		public delegate void SendMessage(string message);
		
		
		static void Main(string[] args)
		{

			SendMessage sayHello, sayGoodbye, multiDelegate;

			sayHello = Hello;
			sayGoodbye = Goodbye;

			multiDelegate = sayGoodbye + sayHello;

			multiDelegate("황윤모");

			Console.WriteLine();

			multiDelegate -= sayGoodbye;

			multiDelegate("황윤모");



		}

		public static void Hello(string message)
		{
			Console.WriteLine("안녕하세요." + message + "......!");
		}

		public static void Goodbye(string message)
		{
			Console.WriteLine("안녕히가세요." + message + "......!");
		}


		
	}
}
