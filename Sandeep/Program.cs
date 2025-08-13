using System;

class MyPrograms
{
    static void Main()
    {
        // Prime Number check
        Console.WriteLine("Is 7 prime? " + IsPrime(7));

        // Palindrome check
        Console.WriteLine("Is 'madam' a palindrome? " + IsPalindrome("madam"));

        // Anagram check
        Console.WriteLine("Are 'listen' and 'silent' anagrams? " + AreAnagrams("listen", "silent"));
    }

    // Check Prime
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++) // check all numbers before it
        {
            if (number % i == 0) return false; // divisible by i, not prime
        }
        return true;
    }

    // Check Palindrome
    static bool IsPalindrome(string text)
    {
        string reverse = "";
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse += text[i];
        }
        return text.Equals(reverse, StringComparison.OrdinalIgnoreCase);
    }

    // Check Anagram
    static bool AreAnagrams(string first, string second)
    {
        char[] arr1 = first.ToLower().ToCharArray();
        char[] arr2 = second.ToLower().ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        return new string(arr1) == new string(arr2);
    }
}
