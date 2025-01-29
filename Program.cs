Console.WriteLine("I am GITing tired of learning Git...");

Console.Write("What is your favorite programming language?");
string choice = Console.ReadLine()!;
File.WriteAllText($"{choice}.txt", choice);
// Mine is Rust! ~ Chase