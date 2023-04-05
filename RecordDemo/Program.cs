// See https://aka.ms/new-console-template for more information


namespace RecordDemo;

class Program
{
    static void Main(string[] args)
    {
        Record1 r1a = new("Leon", "Kennedy");
        Record1 r1b = new("Leon", "Kennedy");
        Record1 r1c = new("Johnny", "Cash");

        Class1 c1a = new("Leon", "Kennedy");
        Class1 c1b = new("Leon", "Kennedy");
        Class1 c1c = new("David", "Cross");

        Console.WriteLine("Record type:");
        Console.WriteLine($"To string: { r1a }");
        Console.WriteLine($"Are the two objects equal: { Equals(r1a, r1b) }");
        Console.WriteLine($"Are the two objects reference equal: { ReferenceEquals(r1a, r1b) }");
        Console.WriteLine($"Are the two objects ==: {  r1a == r1b }");
        Console.WriteLine($"Are the two objects !=: {  r1a != r1c }");
        Console.WriteLine($"Hash code of object A: { r1a.GetHashCode() }");
        Console.WriteLine($"Hash code of object B: { r1b.GetHashCode() }");
        Console.WriteLine($"Hash code of object C: { r1c.GetHashCode() }");

        Console.WriteLine("*******************************");

        Console.WriteLine("Class type:");
        Console.WriteLine($"To string: {c1a}");
        Console.WriteLine($"Are the two objects equal: { Equals(c1a, c1b) }");
        Console.WriteLine($"Are the two objects ==: { c1a == c1b }");
        Console.WriteLine($"Are the two objects !=: { c1a != c1c }");
        Console.WriteLine($"Hash code of object A: {c1a.GetHashCode()}");
        Console.WriteLine($"Hash code of object B: {c1b.GetHashCode()}");
        Console.WriteLine($"Hash code of object C: {c1c.GetHashCode()}");
        Console.ReadLine();
    }
    // Record is a "fancy class"
    // Immutable - The values can not be changed
    public record Record1(string FirstName, string LastName);

    public class Class1
    {
        public string Name { get; init; }
        public string LastName { get; init; }
        public string FirstName { get; }

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
