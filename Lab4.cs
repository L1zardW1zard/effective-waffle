using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Вариант 27
			int n;
			Console.WriteLine("Enter array size:");
			n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];

			Console.WriteLine("Enter array elements:");
			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			// ïåðåä
			for (int i = 0; i < n; i++)
			{
				Console.Write(arr[0] + "\t"+  arr[i] + "\t");
			}
			// ïîñëå
			for (int i = 0; i < n; i++)
            {
				Console.Write(arr[i] + "\t" + arr[0] + "\t");
            }
		}
	}
}
