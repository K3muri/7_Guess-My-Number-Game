using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Guess_My_Number_Game
{
	class human_plays
	{
		public human_plays()
		{
			play();
		}
		
		public void play()
		{
			Random Randomnumber = new Random();

			int ans = Randomnumber.Next(1, 1000);
			int guess = 0;
			bool correct = false;
			int c = 0;

			//Console.WriteLine(ans);
			Console.WriteLine("I'm thinking of a number between 1 and 1000.");

			while (!correct)
			{
				c++;
				Console.Write("Guess: ");
				string input = Console.ReadLine();

				if (!int.TryParse(input, out guess))
				{
					Console.WriteLine("That's not a number.");
					continue;
				}

				if (guess < ans)
				{
					Console.WriteLine($"No, the number I'm thinking is 'higher' than that number.");
				}

				else if (guess > ans)
				{
					Console.WriteLine($"No, the number I'm thinking is 'lower' than that number.");
				}

				else
				{
					correct = true;
					Console.WriteLine("You guessed right!");
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
	}
}
