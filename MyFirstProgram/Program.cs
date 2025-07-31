// a filed is a variable that is declared directly in a class.

// what does private do in the above examples?
// "private" is an access modifier.
// we saw "public" as access modifier in earlier videos.
// "private" specifies that something is accessible only within the class

Person2 john = new Person2();
// john._name = "John"; // this will not work because _name is private

Person3 joinWithMethod = new Person3();
Console.WriteLine(joinWithMethod.GetName());

// method and functions can also have "private" access modifiiers
// if a method/function is private, it can only be accessed within the class
// there are other access modifiers that we won't cover in this coure

Person4 joinWithProperties = new Person4();
Console.WriteLine(joinWithProperties.Name);
Console.WriteLine(joinWithProperties.Name2);
Console.WriteLine(joinWithProperties.Name3);

Console.WriteLine("Setting the name...");
joinWithProperties.MutableName = "John Doe";
Console.WriteLine(joinWithProperties.MutableName);
Console.WriteLine(joinWithProperties.Name);
Console.WriteLine(joinWithProperties.Name2);
Console.WriteLine(joinWithProperties.Name3);

//here is how we declare a field in a class

class Person
{
    private string _name = "James";

    //public void SomeMe()
    //{
    //    this._name = "John";
    //}
}

// we can give a field a vlaue when we declare it
class Person2
{
    private string _name = "James";
}


class Person3
{
    private string _name = "James";

    public string GetName()
    {
        return _name;
    }
}


class Person4
{
    private string _name = "John";

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public string Name2 => _name;
    public string Name3 { get; } = "John";

    public string MutableName
    {
        get { return _name; }
        set { _name = value; }
    }
}