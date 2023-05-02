using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage309
{
    internal class SwordDamageEncapsulated : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;//Private
        private const int FLAME_DAMAGE = 2;//Private
        public SwordDamageEncapsulated(int roll) : base(roll) { }

        protected override void CalculateDamage()//Private
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;

            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
