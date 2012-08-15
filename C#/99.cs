using System;

class Kuku {
	public static void Main() {
		for(int i = 1; i <= 9; i++) {
			for(int j = 1; j <= 9; j++) {
				Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
			}
		}
	}
}