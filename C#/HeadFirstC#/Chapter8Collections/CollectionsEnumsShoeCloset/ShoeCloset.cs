using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsEnumsShoeCloset
{
    internal class ShoeCloset
    {
        List<Shoe> shoes= new List<Shoe>();

        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe");
            for (int i = 0;i < 4; i++)
            {
                Console.WriteLine($"Press {i} to add {(TypeShoe)i}");
            }
            Console.Write("Enter a style: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int type))
            {
                Console.Write("\nEnter the color: ");
                string color = Console.ReadLine();
                Console.Write("Enter the Size:  ");
                int size = Convert.ToInt32( Console.ReadLine());
                shoes.Add(new Shoe((TypeShoe)type, size, color));
            }

            
        }
        public void RemoveShoe()
        {
            Console.Write("\nEnter the number of the shoe to remove: ");
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) &&
            (shoeNumber >= 1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"\nRemoving {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }

        }
        public void  PrintCloset()
        {
            if(shoes.Count == 0)
            {
                Console.WriteLine("Shoe closet is empty");
            }
            else
            {
                Console.WriteLine("The shoe closet contains");
                for (int i = 0; i < shoes.Count; i++)
                {
                    Console.WriteLine($" Shoe #{i + 1} : {shoes[i].Description} ");
                }
            }
        }
    }
}
