// ConcreteComponent.cs
using System;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Test Decorator Design  Assignment!";
    }
}
