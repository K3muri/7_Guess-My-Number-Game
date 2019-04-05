using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Guess_My_Number_Game
{
	class computer_plays
	{
		public computer_plays()
		{
			play();
		}

		public void play()
		{
			Console.WriteLine("human pick a number form 1-100");
			double Mynum = double.Parse(Console.ReadLine());

			Random r = new Random();
			int ans = r.Next(1, 100);
			int low = 1;
			int hig = 100;
			bool correct = false;
			int c = 0;
			
			do
			{
				c++;
				ans = r.Next(low , hig);
				Console.WriteLine($"the low number is {low} the hight is {hig}");
				Console.WriteLine($"computer number is {ans}");
			
				if (ans < Mynum)
				{
					Console.WriteLine("to low " );
					Console.ReadKey();
					if (true)
					{
						low = ans;
					}
				}
				else if (ans > Mynum)
				{
					Console.WriteLine("to hight");
					Console.ReadKey();

					if (true)
					{
						hig = ans;
					}
				}
				else
				{

					correct = true;
					Console.WriteLine("compter guessed right!" );
					Console.WriteLine($"it took {c} guesses");
					Console.ReadLine();
					Console.Write("press 1 to go back to main screen \n" +
									"press 2 to restart this game \n" +
									"press 3 to exit the program \n" +
									"input selection--->");

					string path0 = (Console.ReadLine()).ToLower();
					if (path0.Contains("1"))
					{
						Console.WriteLine("you have select main screen ");
						Console.Clear();
						MainScreen a = new MainScreen();
						
					}
					else if (path0.Contains("2"))
					{
						Console.WriteLine("you have select to restart this game ");
						Console.Clear();
						computer_plays a = new computer_plays();
						
					}
					else 
					{
						Console.WriteLine("you have select to exit the program ");
						Console.ReadLine();
						System.Environment.Exit(0);
					}
				}
			} while (!correct);
			
		}
	}
}
