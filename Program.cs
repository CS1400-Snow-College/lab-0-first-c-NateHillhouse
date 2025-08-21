// See https://aka.ms/new-console-template for more information

string greeting = "Hello, World!";
Console.WriteLine(greeting);

string name = "Nate";
string friend = "Maria";
Console.WriteLine($"Saying hello to a friend: {name}");
Console.WriteLine($"Hello, {name}!");


Console.WriteLine($"two friends: {name} and {friend}");

Console.WriteLine($"The name {name} has {name.Length} characters.");



greeting = "   Hello, World!   ";
Console.WriteLine("Trimming the greeting:");
Console.WriteLine($"[{greeting.Trim()}]");
//Trimming the greeting in a using a variable
var trimmedgreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedgreeting}]");
trimmedgreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedgreeting}]");



Console.WriteLine("Changing to upper and lower case:");
greeting = "Hello, World!";
Console.WriteLine(greeting.ToUpper());
Console.WriteLine(greeting.ToLower());


string phrase = "I see a red door and I want it painted black";
Console.WriteLine($"phrase: {phrase}");
Console.WriteLine($"Does the phrase contain \"red\"? {phrase.Contains("red")}");
Console.WriteLine($"Does the phrase contain \"blue\"? {phrase.Contains("blue")}");


Console.WriteLine("Does it start with \"I see\"? " + phrase.StartsWith("I see"));
Console.WriteLine("Does it end with \"black\"? " + phrase.EndsWith("black"));

Console.WriteLine("Please let me know if there is anyting that I can do to improve! Thank you!");