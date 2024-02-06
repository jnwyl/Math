using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();


        while (true)
        {
            Console.WriteLine("Enter person's name (or 'quit' to finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "quit")
                break;

            Console.WriteLine("Enter person's weight: ");
            int weight;
            if (!int.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid weight. Please enter a valid integer.");
                continue;
            }


            Person person = new Person
            {
                Name = name,
                Weight = weight
            };


            people.Add(person);
        }

        Console.WriteLine("\nList of people:");
        int totalWeight = 0;
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Weight: {person.Weight}");
            totalWeight += person.Weight;
        }
        Console.WriteLine($"Total weight of all people: {totalWeight}");
    }
}
