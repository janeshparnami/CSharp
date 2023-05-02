### _Object Intializer_

> In object initializer, you can initialize the value to the fields or properties of a class at the time of creating an object without calling a [constructor](https://www.geeksforgeeks.org/c-sharp-constructors/). In this syntax, you can create an object and then this syntax initializes the freshly created object with its properties, to the variable in the assignment. It can also place indexers, to initializing fields and properties, this feature is introduced in C# 6.0.

- __Examples__
```
TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy"};
```
```
Geeks objk = new Geeks()
{
	author_name = "Ankita Saini",
	author_id = 102,
	total_articles = 177,
}
```
- Another approach is to use Optional parametrs in the constructor itself. That has cons also, namely when calling from another assembly.
Reference : C# 8.0 in a nutshell oreilly pg 98.

### _Collection Initializer_

> Collection initializer is also similar to object initializers. The collections are initialized similarly like objects are initialized using an object initializer. Or in other words, generally, we used the **Add()** method to add elements in collections, but using a collection initializer you can add elements without using Add() method.

```
int[] ints = new int[2] {1,2};
```

### _Dereferencing_

> Accessing the underlying object whose reference is stored in the variable of reference type.

### Expression-bodied members

> Terse way of declaring Properties.

- Examples
```
public decimal Worth => currentPrice * sharesOwned;

public decimal Worth
{
	get => currentPrice * sharesOwned;
	set => sharesOwned = value / currentPrice;
}

```
[Expression Bodied Members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/expression-bodied-members)

