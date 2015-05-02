using System;

namespace Module2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			const char x = 'X';
			const char o = 'O';

			int i = 1;
			int j = 1;

				


			while (j<=8) {
				while (i<=64){
					if (j % 2 != 0 && i % 2 != 0) {
						Console.Write (x);			    
					} 
					else if (j % 2 != 0 && i % 2 == 0) {
						Console.Write (o);	
					}
					else if (j % 2 == 0 && i % 2 != 0) {
						Console.Write (o);	
					}
					else if (j % 2 == 0 && i % 2 == 0) {
						Console.Write (x);	
					}
					i = i + 1;
					if ((i - 1) % 8 == 0) {
						Console.Write ("\n");
						j += 1;
					}


				}

			}		 

			Console.ReadLine  ();
		}
	



	}
}
