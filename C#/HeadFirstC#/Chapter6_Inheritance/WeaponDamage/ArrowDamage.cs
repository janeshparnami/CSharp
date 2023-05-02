using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage309
{
    internal class ArrowDamage : WeaponDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;//Private
        private const decimal FLAME_DAMAGE = 1.25m;//Private
        private const decimal MAGIC_MUlTIPLIER = 2.5m;

        //Constructor
        public ArrowDamage(int roll) : base(roll) { }
        protected override void CalculateDamage()//Private
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if(Magic) baseDamage *= MAGIC_MUlTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
