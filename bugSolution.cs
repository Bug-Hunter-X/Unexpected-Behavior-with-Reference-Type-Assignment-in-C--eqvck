public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public MyClass Clone() // Add a clone method
    {
        return new MyClass(this.MyProperty);
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = obj1.Clone(); // Create a copy instead of assigning the reference
        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
}