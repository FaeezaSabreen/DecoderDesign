// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating ConcreteComponent
        IComponent<string> component = new ConcreteComponent();

        // Decorating ConcreteComponent with PlainDecorator
        component = new PlainDecorator(component);
        Console.WriteLine("PlainDecorator: " + component.GetText());

        // Decorating ConcreteComponent with UpperCaseDecorator
        component = new UpperCaseDecorator(component);
        Console.WriteLine("UpperCaseDecorator: " + component.GetText());

        // Decorating ConcreteComponent with ColorDecorator
        component = new ColorDecorator(component);
        Console.WriteLine("ColorDecorator: " + component.GetText());
    }
}
