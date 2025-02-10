using System;
using System.Linq;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        if (String.IsNullOrEmpty(word))
        {
            return false;
        }

        if (word.All(char.IsUpper))
        {
            return true;
        }

        if (word.All(char.IsLower))
        {
            return true;
        }

        if (char.IsUpper(word[0]) && word.Skip(1).All(char.IsLower))
        {
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.DetectCapitalUse("USA")); // true
        Console.WriteLine(solution.DetectCapitalUse("FlaG")); // false

        Console.ReadLine(); // Aguarda entrada do usuário antes de fechar
    }
}
