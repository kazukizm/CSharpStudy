using System;

// Question
//  このプログラムは２回キー入力させ
//  １回目に入力した文字列をstring strXに代入し
//  ２回目に入力した文字列をstring strYに代入している。
// 
//  if文を使い、入力された２つの数字を比較し、比較した結果ごとに
//  次のように表示しよう。 
// 
//  ・ｘがｙより大きければ、”ｘのほうが大きい”と表示
//  ・ｙがｘより大きければ、”ｙのほうが大きい”と表示
//  ・同じ数だった場合は”同じ大きさ”と表示
//  
//  
// Hint
//  01_5_KeyInput2の演習を参考にして、strXとstrYをint型に変換し、それぞれをint x,yに代入しよう。
//  そのxとｙを、if文で比較しよう。
//  
namespace _01_6_IfStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ｘに格納する数字を入力してください。(半角の数字のみ)");
			string strX = Console.ReadLine();

			Console.WriteLine("yに格納する数字を入力してください。(半角の数字のみ)");
			string strY = Console.ReadLine();


			// TODO ここにif文を追加してxとｙを比較する処理を下記
			// 大小の関係ごとに「ｘのほうが大きい」などの表示を行おう。
		}
	}
}
