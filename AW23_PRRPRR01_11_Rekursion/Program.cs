using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_11_Rekursion {
	internal class Program {
		static int Factorial(int n) {
			if (n <= 1) { // basfall
				return 1;
			} else {
				return n * Factorial(n - 1);
			}
		}

		static void Main(string[] args) {
			Console.WriteLine(Factorial(-3));
		}
	}
}
