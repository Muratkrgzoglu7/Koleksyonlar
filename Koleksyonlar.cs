using System;
using System.Collections.Generic; //bu kodu List üzerinden yazdırmayı unutmayın. 
								  //list üzerinde fareyi 2 saniye bekletip yanan ampüle tıklayıp kodu yazdırın
namespace Koleksyonlar
{
	class Program
	{
		static void Main(string[] args)
		{
			//String[] isimler1 = new String[] { "Murat", "Mehmet", "Emir", "Yaman" };
			//Console.WriteLine(isimler1[0]);
			//Console.WriteLine(isimler1[1]);
			//Console.WriteLine(isimler1[2]);
			//Console.WriteLine(isimler1[3]);
			//isimler1 = new String[5];
			//isimler1[4] = "Burak";
			//Console.WriteLine(isimler1[4]);
			//Console.WriteLine(isimler1[0]);	
			

			List<string> isimler2 = new List<string> { "Murat", "Mehmet", "Emir", "Yaman" };
			Console.WriteLine(isimler2[0]);
			Console.WriteLine(isimler2[1]);
			Console.WriteLine(isimler2[2]);
			Console.WriteLine(isimler2[3]);
			isimler2.Add("Burak");
			
			Console.WriteLine(isimler2[4]);
			Console.WriteLine(isimler2[0]); 
		}
	}
}
