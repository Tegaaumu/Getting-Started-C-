// lists are used to store multiple values
// - lists are zero based
//- list are dynamic in size
// - we can get values from list
// - we can set values from a list
// - we can add values in a list
// - we can remove values from a list
// - we can insert values into a list
// - we can clear a list
// - we can sort a list!

//here is how we declare a list
List<string> words = new List<string>();
//Or this below
//List<string> words = new();

//here is how we add values to a list
words.Add("one");
words.Add("two");
words.Add("three");

//Here is how we get values from a list
string firstword = words[0]; // "one"
string secoundword = words[1]; // "one"
string thridword = words[2]; // "one"

words[0] = "four"; // Change the first word to "four"

//here is howw we declare and initialize a list

List<int> numbers = new List<int>
{
    1,
    2,
    3,
    4,
};

//here is how we get the count of a list
int count = numbers.Count;

//here is how we remove a value from a list
numbers.Remove(1);
numbers.Remove(2);
numbers.Remove(3);
// numbers is now:
//[4]

//here is how we insert a value into a list
numbers.Insert(0, 1);
// numbers is now:
//[1]
//[4]
numbers.Insert(0, 2);
// numbers is now:
//[2]
//[1]
//[4]
numbers.Insert(1, 3);
// numbers is now:
//[2]
//[3]
//[1]
//[4]
Console.WriteLine(numbers.Count);

//here is how we clear a list
numbers.Clear();

//here is how we sort a list
words.Sort();