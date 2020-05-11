# Homework9
> Use class inheritance with Vehicle, Truck, and Person class

## Screenshot
![screenshot](Homework9.png)

## Instructions
> Create a class called Vehicle that has the Manufracturer name (enum),  
> number of Cyclinders in the engine (int), and the owner (Person, see below).  
> The create a classs called Truck that is derived from Vehicle and has the  
> additional following properties: the load capacity in tons (double), and  
> towing capacity in pounds (int).  Be sure your class has a reasonable set  
> of constructors, getters/setters, properties and suitably defined ToString  
> and Equals methods.  Write a driver program to test all your methods.  
> 
> Finish the definition of the Person class below.  
```cs
public class Person
{
    private String name;
    public Person(){...}
    public Person(string theName){...}
    public Person(Person obj){...}
    public string GetName() {...}
    public void SetName(string name) {...}
    public string ToString() {...}
    public bool Equals(Object obj){...}
}
```