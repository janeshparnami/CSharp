
## Abstract class Vs Concrete class
- AC can not be instantiated.Compiler won't allow this.
- Though AC can't be instantiated still it can have a constructor.
- AC can define abstract methods, properties.
- AC is same as concrete class in all other aspects.
- Use this if class is not to be instantiated. Saves a lot of headache later on.
- Any concrete subclass of the abstract method must implement it.
- If the subclass is also abstract then it can defer the implementatin further down the chain. i.e any concrete class down the hierarchy must implement the method.
- The beauty of defining an abstract method or property in a base class and overriding it in a subclass is that you don’t need to know anything about the subclass to use it. Method will always be implemented.


## Some clarification
Example Code.

```
	internal abstract class AnyClass
	{
		public abstract void Method1(){}
		public void Method2(){}
		public virtual void Method3(){}
	} 
```
---
- Abstract keyword in class here enforces that this class can not be instantiated.
- abstract keyword in Method1() enforces that any subclass must implement it using the keyword override.
- Method2 is just a normal method.
- Method3() can be implemented bys using the keyword Override.

