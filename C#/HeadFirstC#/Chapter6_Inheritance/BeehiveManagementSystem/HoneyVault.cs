using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    internal static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;
        public static string StatusReport 
        {
            get
            {
                string status = $"{honey:0.0} units of honey\n" + $"{nectar:0.0} units of nectar";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING) warnings +=
                "\nLOW HONEY - ADD A HONEY MANUFACTURER";
                if (nectar < LOW_LEVEL_WARNING) warnings +=
                "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                return status + warnings;
            }
            private set { }
        }
        private static float honey = 25f;
        private static float nectar = 100f;

        public static void CollectNectar(float amount)
        {
            if (amount > 0)
                nectar += amount;
        }
        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            honey += nectarToConvert > nectar ? nectar * NECTAR_CONVERSION_RATIO : nectarToConvert * NECTAR_CONVERSION_RATIO;
        }
        public static bool ConsumeHoney(float amount)
        {
            if (amount > honey) return false;
            else
            {
                honey -= amount;
                return true;
            }
        }

    }
}
