using System;
using System.Collections.Generic;
using System.Text;

namespace PlsWorkFfs
{
    class Randomizer
    {
		public int[] arrNumbers = new int[5];
		Random arrRand = new Random();
		int randNumber;

		public int[] NumberRandomizer()
		{
			for (int i = 0; i < 5; i++)
			{
				randNumber = arrRand.Next(1, 50);
				arrNumbers[i] = randNumber;
			}
			return arrNumbers;

		}


	}

}
