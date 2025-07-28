﻿// a foreach loop is used to iterate over a 
// collection of values
// to be more specific, it iterates over
// things that are "IEnumerable"
// all collections are IEnumerable!

// here is what a foreach loop looks like
// foreach (Type thing in collectionOfThings)
// {
//      do something.....
//}

// let's see a real example with a number array!
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int item in numbers)
{
    Console.WriteLine(item);
}

//what about with... a list of strings?
List<string> words = new List<string>
{
    "red",
    "green",
    "blue",
};
foreach (string word in words)
{
    Console.WriteLine(word);
}

Dictionary<string, int> ages = new()
{
    ["James"] = 63,
    ["Mary"] = 31,
    ["Ben"] = 87,
    ["Lucky"] = 23,
};

//foreach (KeyValuePair<string, int> person in ages)
foreach (var person in ages)
{
    Console.WriteLine($"{person.Key} is {person.Value} years old");
}

// we can use break and continue in a foreach loop
// just like other loops too!
foreach (int number in numbers)
{
    if (number == 3)
    {
        break;
    }
    Console.WriteLine(number);
}