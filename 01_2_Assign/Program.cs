using System;

// Question
// 1.int型の変数xに数値11を代入し、xの値を"x=11"のように表示しよう。
// 2.int型の変数xに数値5を代入、int型の変数yに数値3を代入し 
//  xとyを足し算した結果をint型変数zに代入し"z=8"と表示しよう。
// Hint
//  Console.WriteLine() の引数に変数使って値を表示しよう。
//  例）
//  Console.WriteLine("x=" + x);
namespace _01_2_Assign
{
	class Program
	{ 
		static void Main(string[] args)
		{
            int x = 11, y = 3, z;
            Console.WriteLine("x="+x);
            x = 5;
            z = x + y;
            Console.WriteLine("z="+z);


			// 回答例
/*
			int x = 11;
			Console.WriteLine("x=" + x);

			// C言語では、変数は関数の頭で宣言しないといけないルールだが
			// C#は使いたいタイミングのところで宣言しても良い。
			// 変数は必要になったときに宣言するほうが、プログラムの見通しがよくなることが多い。
			x = 3;
			int y = 3;
			int z = x + y;
			Console.WriteLine("z=" + z);
*/

		}
	}
}
