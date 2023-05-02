## Differences
- Class can extend only one [[Abstract Class]] whereas it can implement multiple [[Interfaces]].
- [[Abstract Class]] methods can be both abstract and concrete.
- [[Abstract Class]] can have constructors whereas [[Interfaces]] can not have.
- [[Abstract Class]] can have fields, methods, events , properties whereas [[Interfaces]] can have methods, properties and events.It can not have fields.
- For Abstract methods, we need to use the override word in the subclass that extends it, whereas in the case of [[Interfaces]] we do not.


## Common 
- Abstract methods in both have the method declaration as follows
- The only difference is that in an [[Abstract Class]] the method must be explicitly marked as abstract whereas in [[Interfaces]] they are implicitly abstract so no need to write the abstract keyword.
- Any method that is abstract either implicitly or explicitly must be implemented in the base class.
- Both can not be instantiated.
- 

```
void Method1();
```
