// See https://aka.ms/new-console-template for more information
using System.Linq;

//Combine Two Collections
Console.WriteLine("/********************Combine Two Collections********************/");
var fruits = new[] { "Apple", "Banana", "Cherry" };
var colors = new[] { "Red", "Yellow", "Dark Red" };

var combined = fruits.Zip(colors, (fruit, color) => $"{fruit} is {color}");

foreach (var pair in combined)
{
    Console.WriteLine(pair);
}


//Combine Three Collections
Console.WriteLine("/********************Combine Three Collections********************/");
var names = new[] { "Alice", "Bob", "Charlie" };
var ages = new[] { 25, 30, 35 };
var cities = new[] { "New York", "London", "Tokyo" };

var people = names.Zip(ages)
                  .Zip(cities, (nameAge, city) => $"{nameAge.First}, {nameAge.Second}, from {city}");

foreach (var person in people)
{
    Console.WriteLine(person);
}