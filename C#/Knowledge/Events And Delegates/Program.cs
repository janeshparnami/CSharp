namespace Events_And_Delegates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Unicast Delegates
			//UnicastDelegates unicastDelegates = new UnicastDelegates();
			//unicastDelegates.sender = Reciever; 
			//Console.WriteLine("In main thread - Before HugeProcess");
			//Thread thread = new Thread(new ThreadStart(unicastDelegates.HugeProcess));
			//thread.Start();

			//Multicast Delegates
			//MulticastDelegates multicastDelegate = new MulticastDelegates();
			//multicastDelegate.sender += Reciever;
			//multicastDelegate.sender += Reciever1;
			//multicastDelegate.sender += Reciever2;

			//multicastDelegate.sender = null; //This is called nakedness of Delegates bcoz a reciever can set it to null

			//Console.WriteLine("In main thread - Before HugeProcess");
			//Thread thread = new Thread(new ThreadStart(multicastDelegate.HugeProcess));
			//thread.Start();

			UsingEvents usingEvents = new UsingEvents();
			usingEvents.sender += Reciever;
			usingEvents.sender += Reciever1;
			usingEvents.sender += Reciever2;

			//usingEvents.sender = null; // Uncomment this line to read the error
			//The error is becasue when creating a delegate type "sender" we used the event keyword which enforces the condition that subscriber cannot "null" the Publisher.

			Console.WriteLine("In main thread - Before HugeProcess");
			Thread thread = new Thread(new ThreadStart(usingEvents.HugeProcess));
			thread.Start();

		}

		private static void Reciever(int i)
		{
			Console.WriteLine($"Reciever0 : {i}");
		}

		private static void Reciever1(int i)
		{
			Console.WriteLine($"Reciever1 : {i}");
		}

		private static void Reciever2(int i)
		{
			Console.WriteLine($"Reciever2 : {i}");
		}
	}
}