string[] text = { "Hello", "world", "2", ":-)", "12", "computer science" }; 
var result = text.Where(input => input.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();