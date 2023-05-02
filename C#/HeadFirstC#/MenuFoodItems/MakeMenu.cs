using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFoodItems
{
    internal class MakeMenu
    {
        public void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;
            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel"
 };
                }
                menuItems[i].Generate();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(menuItems[i].Description);
                Console.WriteLine(menuItems[i].Price);

            }
            MenuItem specialMenuItem = new MenuItem()
            {
                Proteins = new string[] { "Organic ham", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };
            specialMenuItem.Generate();
            Console.WriteLine(specialMenuItem.Description);
            Console.WriteLine(specialMenuItem.Price);

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamolePrice = guacamoleMenuItem.Price;
            Console.WriteLine($"Add guacamol menu Item for: {guacamolePrice}");
        }
    }
}
