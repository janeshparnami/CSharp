1. Copying a subclass reference to a superclass is easy. But, copying a superclass reference to a subclass is not.

__This works__
```
HoneyManufacturer lily = new HoneyManufacturer();
Bee hiveMember = lily;
```

__This will also work__
```
HoneyManufacturer daisy = new HoneyManufacturer();
IWorker worker = daisy;
```
__This will not__
```
IWorker pearl = new HoneyManufacturer();
NectarCollector irene = (NectarCollector)pearl;
```

_Why is this so?_

---
2. What does C# provide us with to remedy this?(__Hint: [[is,as, upcasting,downcasting]]) 
3. Explain Method Hiding with examples?




[[Q -- Interfaces]]
[[is,as, upcasting,downcasting]]
[[Q -- Stack and Heap]]
