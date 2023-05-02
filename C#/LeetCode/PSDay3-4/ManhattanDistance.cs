using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSDay3_4
{
    internal class ManhattanDistance
    {
        public static int NearestPoint(int x, int y, int[][] points)
        {
            int smallestDist = int.MaxValue;
            int smallestInd = -1;
            int xElement;
            int yElement;

            for (int i = 0; i < points.Length; i++)
            {
                xElement = points[i][0];
                yElement = points[i][1];
                if(xElement == x || yElement == y)
                {
                    int tempDis = Distance(x, y, xElement, yElement);
                    if (tempDis < smallestDist)
                    {
                        smallestDist = tempDis;
                        smallestInd = i;
                    }
                }
            }
            return smallestInd;
        }

        /*This is the manhattan distance*/
        private static int Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}
