using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Adding the prime minister in list
        Dictionary<string, int> primeMinisters = new Dictionary<string, int>
        {
            { "Atal Bihari Vajpayee", 1998 },
            { "Narendra Modi", 2014 },
            { "Manmohan Singh", 2004 }
        };

        //Finding the Prime Minister of 2004
        string find_primeMinister= primeMinisters.FirstOrDefault(item => item.Value == 2004).Key;
        if (!string.IsNullOrEmpty(find_primeMinister)){
            Console.WriteLine($"The Prime Minister of 2004 is {find_primeMinister}.");
        }
        else{
            Console.WriteLine("No Prime Minister found ");
        }

        // Adding the current Prime Minister to the dictionary
        string currentPrimeMinister = "Shri Narendra Modi";
        int currentYear = 2024;
        primeMinisters[currentPrimeMinister] = currentYear;  //key value store in dictionary

        // Sorting the dictionary 
        var sortedPrimeMinisters = primeMinisters.OrderBy(item => item.Value);  //sorted by value in this case the value is year

        // Printing the dictionary
        Console.WriteLine("\nPrime Ministers sorted by year:");
        foreach (var primeMinister in sortedPrimeMinisters)
        {
            Console.WriteLine($"{primeMinister.Value}: {primeMinister.Key}");   
        }
    }
}
