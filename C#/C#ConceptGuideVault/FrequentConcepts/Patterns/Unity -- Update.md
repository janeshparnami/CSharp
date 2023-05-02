1) __Update() -- if -- return__
	```
	void Update()
	{
		if(!something)
		{
			DoSomething;
			return;	
		}
	}
	```

> The code will only move forward inside the update function when `DoSomething` makes `something` `true` otherwise it will go inside the if conditional and `return` will exit the update loop.

==MyAnalysis:== This Pattern  produces one bool check per frame, but removes a lot of potential errors if the code below depends on `something` but it is not true yet.
2)  