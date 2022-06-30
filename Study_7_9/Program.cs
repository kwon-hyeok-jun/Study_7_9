using System;

/*
class CharacterDemo
{
    static void Main(string[] args)
    {
        
        char grade = 'A';
        char kor = '가';

        Console.WriteLine(grade);
        Console.WriteLine(kor);

        string name = "박용준";
        Console.WriteLine("안녕하세요, {0}입니다.", name);

        string multilines = @"
            안녕하세요.
            반갑습니다.
            ";

        Console.WriteLine(multilines);

        int num = 3;
        string str = "korea";

        Console.WriteLine($"{num}과 {str}");

        Char c = 'A';
        String s = "안녕하세요 ";
        bool b = true;

        Console.WriteLine("{0}\n{1}\n{2}", c, s, b);
        
    }
}
*/

class ReadLineDemo
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("이름을 입력하세요 : ");
        string a = Console.ReadLine();
        Console.WriteLine("안녕하세요," + $"{a}님");
        

        int x = Console.Read();
        Console.WriteLine(x);
        Console.WriteLine(Convert.ToChar(x));
        


        Console.Write("정수를 입력하세요 : ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        Console.WriteLine($"{number} - {number.GetType()}");
        
        byte x = 10;

        Console.WriteLine($"십진수 : {x} -> 이진수 : {Convert.ToString(x,2).PadLeft(8,'0')}");
        */

        Console.WriteLine("아무키나 누르세요.");
        ConsoleKeyInfo key = Console.ReadKey(true);
        Console.WriteLine("{0}", key.Key);
        Console.WriteLine("{0}", key.KeyChar);
        Console.WriteLine("{0}", key.Modifiers);
        if (key.Key == ConsoleKey.I)
        {
            Console.WriteLine("I를 입력했습니다.");
        }
    }
}