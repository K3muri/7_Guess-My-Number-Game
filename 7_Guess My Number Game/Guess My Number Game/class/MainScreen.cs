using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Guess_My_Number_Game
{
	class MainScreen
	{

		public MainScreen()
		{
			play();
		}

		public void play()
		{
			Console.Write("press 1 to go human vs compter (human picks number) \n" +
						 "press 2 to to go to compter vs human (compter picks number) \n" +
						 "press 3 to exit the program \n" +
							"input selection--->");
			
			string path0 = (Console.ReadLine()).ToLower();
			if (path0.Contains("1"))
			{
				Console.WriteLine("you have select  human vs compter ");
				Console.Clear();
				computer_plays a = new computer_plays();
			}

			else if (path0.Contains("2"))
			{
				Console.WriteLine("you have select  compter vs human ");
				Console.Clear();
				human_plays a = new human_plays();
			}

			else
			{
				Console.WriteLine("you have select to exit the program ");
				Console.ReadLine();
				System.Environment.Exit(0);
			}
		}
	}
}
