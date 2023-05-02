using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_s_Toy
{
	internal class RemoteControlCar
	{
		public float Distance { get; private set; } = 0;

		public float Battery { get; private set; } = 100;

		public static RemoteControlCar Buy()
		{ 
			return new RemoteControlCar();
		}
		public string DistanceDisplay()
		{
			return $"Driven {Distance} meters";
		}
		public string BatteryDisplay()
		{
			if(Battery != 0) 
				return $"Battery at {Battery}%";
			return "Battery empty";
		}

		public void Drive()
		{
			if(Battery !=  0) 
			{	
				Battery -= 1;
				Distance += 20;
			}
		}
	}
}
