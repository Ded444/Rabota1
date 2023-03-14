using System;
class Lab4 {
  static void Main() {
   string input = "Я! не учусь в рмт!!!";
    string[] words = input.Split(' ');
    string longestWord = "";
    foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
        }           
Console.WriteLine($"Самое длинное слово - '{longestWord}' включает в себя {longestWord.Length} символов.");
    }
}