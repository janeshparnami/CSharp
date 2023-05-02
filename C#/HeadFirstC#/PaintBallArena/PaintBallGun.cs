using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallArena
{
    internal class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded) //This was added Later
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }
        public int MagazineSize { get; private set; } = 16; //Changed from const to Property
        private int balls = 0;

        public int BallsLoaded { get; set; }
        public bool IsEmpty() { return BallsLoaded == 0; }

        public int Balls //Changed to property
        {
            get { return balls; }
            set
            {
                if(value > 0)
                    balls = value;
                Reload();
            }
        }
        public void Reload()
        {
            if (balls > MagazineSize)
                BallsLoaded = MagazineSize;
            else
                BallsLoaded = balls;
        }
        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }

    }
}
