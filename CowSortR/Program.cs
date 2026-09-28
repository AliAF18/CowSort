namespace CowSortR;
using System;
using System.Collections.Generic;
internal class Program

{
    public static void Main(string[] args)
    {
        string filePath = "cows.txt"; 
        List<Cow> cows = new List<Cow>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Datei nicht gefunden.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string trimmedLine = line.Trim();

            if (string.IsNullOrWhiteSpace(trimmedLine))
                continue;

            if (trimmedLine.StartsWith("#"))
                continue;

            string[] parts = trimmedLine.Split(';');

            if (parts.Length < 3 || string.IsNullOrWhiteSpace(parts[0]))
                continue;

            if (int.TryParse(parts[2], out int age))
            {
                cows.Add(new Cow(parts[0].Trim(), parts[1].Trim(), age));
            }
        }

        foreach (var cow in cows)
        {
            Console.WriteLine(cow);
        }
      
    }
}
