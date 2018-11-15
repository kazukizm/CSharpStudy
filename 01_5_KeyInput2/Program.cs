using System;

// Question
//  このプログラムはキー入力で入力した文字列をstring strに代入している。
//  
//  str変数に格納された文字列を、int型に変換してint xに代入しよう。
//  そしてそのｘを表示してみよう。
//  
// Hint
//  ひとつ前の問題ではConsole.ReadKey()で、「どのキーが押されたか？」を表示したが
//  今回はConsole.ReadLine()を使って入力された文字列を受け取っている。
//  受け取った文字列をプログラムで加工する。
namespace _01_5_KeyInput2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("好きな数字を入力してください。(半角の数字のみ)");

			// キーボードで入力した文字列をstrで受け取る。
			string str = Console.ReadLine();

            // TODO 文字列をint型に変換する処理を調べてここに追加。
            int x = Convert.ToInt16(str);
			// ｘの内容を表示させる。
			Console.WriteLine("入力した数字="+x);
		}
	}
}
