using System;

namespace Randomizer
{
	class Randomizer
	{
		int[] arrNumbers = new int[5];
		Random arrRand = new Random();
		int randNumber;

		public void NumberRandomizer(int[] Numbers)
	{
			

			for (int i = 0; i < 5; i++)
			{
                randNumber = arrRand.Next(1, 50);
				arrNumbers[i] = randNumber;
			}
			Numbers = arrNumbers;
			return;

		}
	}
}
