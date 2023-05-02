using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamagePg229
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;//Private
        public const int FLAME_DAMAGE = 2;//Private
        public int Roll;
        public decimal MagicMultiplier = 1M;//Private
        public int FlamingDamage = 0;//Private
        public int Damage;
        public void CalculateDamage()//Private
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
        }
        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
        }
        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
