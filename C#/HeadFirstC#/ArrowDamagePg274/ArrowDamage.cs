using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamagePg229
{
    internal class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;//Private
        private const decimal FLAME_DAMAGE = 1.25m;//Private
        private const decimal MAGIC_MUlTIPLIER = 2.5m;
        private int roll;
        public int Roll
        {
            get { return roll; }
            set 
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public int Damage { get; private set; }

        //Constructor
        public ArrowDamage(int roll)
        {
            Roll = roll;
            CalculateDamage();
        }

        private void CalculateDamage()//Private
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if(Magic) baseDamage *= MAGIC_MUlTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
