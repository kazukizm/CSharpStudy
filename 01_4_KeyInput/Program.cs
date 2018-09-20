using System;

// Question
//  キーの入力を受け取り、押されたキーを"あなたが押したキーは？です"と表示しよう。
// Hint
//  キーのキーの入力を受け取りにはConsole.ReadKey()を使ってみよう。
//  Console.ReadKey()の戻り値で受け取った情報を表示する。
namespace _01_4_KeyInput
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("好きなキーを押してください。");
			// ここに処理を追加。
			Console.WriteLine("あなたが押したキーは" +"??"+ "です");
		}
	}
}
