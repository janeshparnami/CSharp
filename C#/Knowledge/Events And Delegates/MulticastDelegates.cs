using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_And_Delegates
{
	internal class MulticastDelegates
	{
		public delegate void Sender(int i);
		public Sender sender;

		public void HugeProcess()
		{
			for (int i = 0; i < 10; i++)
			{
				Thread.Sleep(1000);
				sender.Invoke(i); //Callback
			}
		}
	}
}
