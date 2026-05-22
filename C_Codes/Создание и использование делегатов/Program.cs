using System;

public delegate string TransformString(string input);

class Program
{
  static string[] ProcessStrings(string[] strings, TransformString transformer)
  {
    string[] result = new string[strings.Length];
    
    for (int i = 0; i < strings.Length; i++)
    {
      result[i] = transformer(strings[i]);
    }
        
    return result;
  }
    
  static void Main()
  {
    string[] words = { "кот", "нос", "лето", "торт", "привет" };
    
    Console.WriteLine("1:");
    foreach (string word in words)
    {
      Console.WriteLine(word);
    }
    
    string[] reversedWords = ProcessStrings(words, 
      str => new string(str.Reverse().ToArray())
    );
    
    Console.WriteLine("\n2:");
    foreach (string word in reversedWords)
    {
      Console.WriteLine(word);
    }
  }
}