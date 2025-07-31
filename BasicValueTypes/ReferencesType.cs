//// object oriented programming is a programming paradigm
//// that uses objects and classes in programming 
//// we can structure a program by bundling related
//// properties and behaviours into individual objects
//// this means that for the first time we start to think
//// about our programs less like just a series of steps
//// and more like a collection of things that interact!

//// in C# we can create by using the class keyword

//// we can create an object from a aclass using the new keyword
//OurClass ourObject = new OurClass();

//// we can use the short-form method to create an object
//OurClass OuObject2 = new();

//// let's make a new instance!
//OurSecoundClass ourSecoundObject = new();
//ourSecoundObject.ExampleMethod();

//int result = ourSecoundObject.ExampleFunction();


//// where else have we seen classes and objects?
//// the console class!
//Console.WriteLine("This is a method on the console class!");

//// Console.writeline looks a little bit different.....
//// why didin't we have to create a new Console object?
//// we'll see why in a later lesson!

////objects are "reference types" in C#
//// and up until now we've only been working with
//// "value types" like int, double, and bool
//// .... except for our collections!

//OurClass object1 = new OurClass(); // new references
//OurClass object2 = new OurClass(); // new references
//OurClass object3 = object1; // same reference as object1

//Console.WriteLine("Object1 === Object2:");
//Console.WriteLine(object1 == object2); // false
//Console.WriteLine("Object1 === Object3:");
//Console.WriteLine(object1 == object3); // true

//// collections are very mush same!
//List<int> myNumber1 = new List<int> { 1, 2, 3 };
//List<int> myNumber2 = new List<int> { 1, 2, 3 };


//Console.WriteLine("myNumber1 === myNumber2:");
//Console.WriteLine(myNumber1 == myNumber2); // false

//// let's wrap up with re-examining parameter passing
//// with value types and reference types!
//void ChangeValue(int value)
//{
//    value = 42;
//}

//int myVlaue = 12337;
//Console.WriteLine("MyValue Before ChangeValue:");
//Console.WriteLine(myVlaue); // 1337
//ChangeValue(myVlaue);
//Console.WriteLine("MyValue After ChangeValue:");
//Console.WriteLine(myVlaue); // 1337

//void ChangeReference(List<string> words)
//{
//    words.Add("form");
//    words.Add("Dev");
//    words.Add("Leader");

//    words = new List<string>();
//}

//List<string> myWords = new List<string> { "Hello", "Word" };
//Console.WriteLine("MyWord Before ChangeReferences:");
//Console.WriteLine(string.Join(" ", myWords)); // Hello World
//ChangeReference(myWords);
//Console.WriteLine("MyWord After ChangeReferences:");
//Console.WriteLine(string.Join(" ", myWords)); // Hello World from Dev Leader

//// this is because when we pass a value type to a method
//// we're passing a copy of the value but when we pass a 
//// references typr we're passing the reference!


//public class OurClass
//{
//};


//// rememeber the methods and functions we were creating?
//// we can now create methods and functions that are 
//// associated with a class!

//public class OurSecoundClass
//{
//    public void ExampleMethod()
//    {
//        Console.WriteLine("Hello from our method!");
//    }

//    public int ExampleFunction()
//    {
//        return 42;
//    }
//}