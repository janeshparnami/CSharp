# Stack
- ___Call Stack___
	- Intrinsic to C# runtime.
	- When we call Stack in reference to C# we mean the call stack.
- ___Stack Data structure___
	- Stack
- __2 Roles of Stack__
	-  to keep track of the method that control should return to once the currently executing method has finished
	- to hold the values of local variables (i.e. the variables that are not needed once their containing method finishes executing).
- __Stack Frame__
	- Local variables pertaining to a method are grouped together.

# Heap
- __Managed Heap__
	- When we refer to heap in the context of C# we mean the managed heap.
- Used to store reference type variables.

# Where do variables live?
- Local variables - those that are declared inside methods
	- Stack
	- This means their values are stored on the stack, therefore meaning that local reference type variables have references stored on the stack and local value type variables have actual values stored on the stack.
- Objects of Reference type variables
	- Heap
-  Instance variables that are part of a reference type instance (e.g. a field on a class) are stored on the heap with the object itself.
-  Instance variables that are part of a value type instance are stored in the same context as the variable that declares the value type. This means that a variable of a struct that is declared in a method will live on the stack, whilst a variable of a struct that is declared inside a class (i.e. a field on the class) will live on the heap.
