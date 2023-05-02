1. Superclass reference holds a reference to a subclass object.How can you access methods and fields in the derived class?
	- Use the __'is'__ keyword in an __'if'__ statement to check whether the object is what you desire.
	- For example.
		```
		if(animal is Hippo hippo){
				hippo.Swim();
				}
		```
	- Here __animal is Hippo__ checks whether the object referenced by animal reference is Hippo object or not and returns a bool.
	- If true, it assigns the reference to a new Hippo cariable called hippo.
	- This is just casting, but the is statement is doing the casting for you.
	- You can also use to see if an object implements an interface or not by using the __is__ keyword.
		```
		if (animal is ISwimmer swimmer)
		 {
			 swimmer.Swim();
		 }
		```
	- In the above example this will return true and copy the reference to swimmer if the animal reference pointing to an object implements the ISwimmer interface. 
	- Above examples is what we call a __type pattern.__ 
	- [is keyword](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/expressions#111111-the-is-operator)
---

2. Another keyword to remedy this is __'as'__ .

	```
	 NectarCollector irene = pearl as NectarCollector;
	 if(irene != null)
	 {
		 //Do Something with the NectarCollector Object
	 }
	```
	- If found , set the refernce otherwise set as null.
	- Used for __Downcasting__.
	- __Note :__ __as__ operator is only useful when there is a subsequent test for __null__. Otherwise, casting is advantageous.

	  ```
	  int shares = ((Stock)a).SharesOwned; // Approach #1
	  int shares = (a as Stock).SharesOwned; // Approach #2
	  ```
    > Approach 1 gives InvalidCastexception.
    > Approach 2 gives NullReferenceException.
    > Clearly approach 1 is more descriptive.
