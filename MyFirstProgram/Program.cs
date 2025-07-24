// Form int to double
int myInt = 4;
double myDouble = myInt;
Console.WriteLine(myInt);
Console.WriteLine(myDouble);

// Form double to int
myDouble = 5.5;
myInt = (int) myDouble;
Console.WriteLine(myDouble);
Console.WriteLine(myInt);

//Converting string to Int/Double
string myString = "5";

//The below method of casting is wrong
//myInt = (int)myString;

//Below is the right way of casting
myInt = int.Parse(myString);
Console.WriteLine($"My string { myString}");
Console.WriteLine($"Parsing string to int {myInt}");
