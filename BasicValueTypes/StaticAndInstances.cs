//// static is a modifier that makes a member belong to a type, rather than an "instances" of a type
//// we can even make an entire classes static.

//// note that we make an instance of "MystaticClass" because it is marked static
////MyStaticClass mystaticClass = new MyStatic(); // this will not work!

////static classes cannot have instance members, so anything inside of a static class must also be static
//MyStaticClass.MyStaticMethod();
////MyStaticClass.MyStaticMethodWork(); //This will not work

//// notice how we don't need to make an instance of "MystaticClass" to call MyStaticMethod?
//// this is just like Console.WriteLine! this means that Console.WriteLine is a Static method!
//MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
//MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

//Console.WriteLine("Before mutating properties on MyNonStaticClass...");
//myNonStaticClass1.MyInstanceMethod();
//myNonStaticClass2.MyInstanceMethod();
//MyNonStaticClass.MyStaticMethod();

////let's mutate these things and see what happens!
//myNonStaticClass1.MyInstanceProperty = "Dev";
//myNonStaticClass2.MyInstanceProperty = "Leader";
//MyNonStaticClass.MyStaticProperty = "Nic Consentino";

//Console.WriteLine("After mutating properties on MyNonStaticClass...");
//myNonStaticClass1.MyInstanceMethod();
//myNonStaticClass2.MyInstanceMethod();
//MyNonStaticClass.MyStaticMethod();

////on non-static classes, we *can* add static memebers
//class MyNonStaticClass
//{
//    public string MyInstanceProperty { get; set; } = "Nick";

//    public static string MyStaticProperty { get; set; } = "Cosentino";

//    public static void MyStaticMethod()
//    {
//        Console.WriteLine($"The static property value is: {MyStaticProperty}");

//        //The below will not work because MyInstancesProperty is not static
//        //Console.WriteLine($"The instance property value is: {MyInstanceProperty}");

//    }

//    public void MyInstanceMethod()
//    {
//        Console.WriteLine($"The instance property value is: {MyInstanceProperty}");

//        //The below will work because MyInstancesProperty is static properties on an instance method
//        Console.WriteLine($"The static property value is: {MyStaticProperty}");

//    }
//}

//static class MyStaticClass
//{
//    public static void MyStaticMethod()
//    {
//        Console.WriteLine("I am a static method!");
//    }
//    //public void MyStaticMethodWork()
//    //{
//    //    Console.WriteLine("I am a static method!");
//    //}
//}
