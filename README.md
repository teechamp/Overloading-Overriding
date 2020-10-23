# Overloading-Overriding
Method overloading is a form of polymorphism in OOP. Polymorphism allows objects or methods to act in different ways, according to the means in which they are used. 
One such manner in which the methods behave according to their argument types and number of arguments is method overloading. we also have overriding and hiding. 

In C#,  method overloading is when Two or more than two methods have the same name but different parameters.
Method overloading in C# can be performed by changing the number of arguments and the data type of the arguments.
In a class we can implement two or more methods with the same name. 
Overloaded methods are differentiated based on the number and type of parameter passed as arguments to the methods..
The advantage of method overloading is that it increases code readability and maintainability.

Method Overriding in C# is similar to the virtual function in C++. Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class. 
Creating a method in the derived class with the same signature as a method in the base class is called as method overriding.
In simple words, Overriding is a feature that allows a subclass or child class to provide a specific implementation of a method that is already provided by one of its super-classes or parent classes. 
When a method in a subclass has the same name, same parameters or signature and same return type(or sub-type) as a method in its super-class, 
Then the method in the subclass is said to override the method in the super-class. 
Method overriding is one of the ways by which C# achieve Run Time Polymorphism(Dynamic Polymorphism).

The method that is overridden by an override declaration is called the overridden base method. 
An override method is a new implementation of a member that is inherited from a base class. 
The overridden base method must be virtual, abstract, or override..

Keywords in Method Overriding
 
There are the following 3 types of keywords used in C# for method overriding:

Virtual Keyword.....
 
It tells the compiler that this method can be overridden by derived classes.
public virtual int myValue()  
{  
    -  
    -  
    -  
}

  Override Keyword....
 
In the subclass, it tells the compiler that this method is overriding the same named method in the base class.
public override int myValue()  
{  
     -  
     -  
     -  
} 

Base Keyword....
 
In the subclass, it calls the base class method for overriding functionality.
base.myValue();  

