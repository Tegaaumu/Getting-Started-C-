// constructors are used to initialize a class

//ExplicitConstructor explicitConstructor = new ExplicitConstructor();
//Console.ReadLine();

//ConstructorWithParameter constructorWithParameter = new ConstructorWithParameter("Hello World!");
//Console.ReadLine();


//MultipleConstructors multipleConstructors = new();
////MultipleConstructors multipleConstructors = new("testing the soil");
//Console.ReadLine();

//OurCollectionOfWords instance = new();
//instance.Add("Hello");
//instance.Add("Word");
//instance.Print();
//Console.ReadLine();

//List<string> nameOfList = new List<string>() 
//{ 
//    "Tega", "David", "Tega", "mary"
//};
//OurCollectionOfWords2 instance = new(nameOfList);
//instance.Print();
//Console.ReadLine();

// Note the below we called the static constructor twice when we called the two instances
// But it will only call the static Constructor one because it's constructor is static unlike public sonstructor.
//var t1 = new StaticConstructor();
//var t2 = new StaticConstructor();
//Console.ReadLine();

OurClassWithAHiddenConstructor ourClassWithAHiddenConstructor = new(5);
Console.ReadLine();


//this has a constructor even though we can't see it
class ImplicitConstructor
{

}

// this class has a parameterless constructor
class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        Console.WriteLine("ExplicitConstructor constructor called");
    }
}

// this class has a constructor that takes in a value

class ConstructorWithParameter
{
    public ConstructorWithParameter(string message)
    {
        Console.WriteLine(message);
    }
}
//this is a class with nultiple constructors "chained"
// together by using : this() syntax

class MultipleConstructors
{
    // here we chain the below one to this one in case
    // there is no message so it provide a default message
    public MultipleConstructors() 
        : this("This is the default message!")
    {
    }
    public MultipleConstructors(string message)
    {
        Console.WriteLine(message);
    }
}

class OurCollectionOfWords
{
    private List<string> _strings;
    public OurCollectionOfWords()
    {

        // we can initialize the list here! this
        // will make its safe for us to use the list
        // later on in the class
        _strings = new List<string>();
    }

    public void Add(string message)
    {
        _strings.Add(message);
    }

    public void Print()
    {
        foreach (var item in _strings)
        {
            Console.WriteLine(item);
        }
    }
}

class OurCollectionOfWords2
{
    private List<string> _strings;
    public OurCollectionOfWords2(List<string> words)
    {
        _strings = new List<string>();

        foreach (var item in words)
        {
            _strings.Add(item);
        }

        // we can initialize the list here! this
        // will make its safe for us to use the list
        // later on in the class
        //_strings = new List<string>();
    }

    public void Print()
    {
        foreach (var item in _strings)
        {
            Console.WriteLine(item);
        }
    }
}
class StaticConstructor
{
    static StaticConstructor()
    {
        Console.WriteLine("StaticConstuctor constructor called");
    }
}
class OurClassWithAHiddenConstructor
{
    public OurClassWithAHiddenConstructor(int value)
        : this()
    {
        Console.WriteLine(
            $"This is the public constructor and " +
            $"we recieved value {value}");
    }
    private OurClassWithAHiddenConstructor()
    {
        Console.WriteLine(
            "Nobody can call this constructor " +
            "directly from the outside!");
    }
}
