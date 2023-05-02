using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bird_Watcher
{
	internal class BirdCount
	{
		private int[] _thisWeek = new int[7];
		private int[] _lastWeek = new int[7];

		public BirdCount(int[] thisWeek) 
		{
			_thisWeek = thisWeek;
		}
		public static int[] LastWeek()
		{
			return new int[] { 0, 2, 5, 3, 7, 8, 4 };
		}

		public int Today()
		{
			return _thisWeek.Last();
		}

		public int IncrementTodaysCount()
		{
			_thisWeek[_thisWeek.Length - 1] = _thisWeek.Last() + 1;
			return _thisWeek.Last();
		}

		public bool HasDayWithoutBirds()
		{
			return _thisWeek.Contains(0);
		}
		
		public int CountForFirstDays(int days)
		{
			return _thisWeek.Take(days).Sum();
		}

		public int BusyDays()
		{
			return _thisWeek.Where(x => x >= 5).Count();
		}
	}
}
