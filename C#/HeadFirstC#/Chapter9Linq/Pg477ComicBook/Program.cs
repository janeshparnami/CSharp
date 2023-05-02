﻿using System.Collections.Generic;
using System.Linq;

namespace Pg477ComicBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mostExpensive = 
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
            }
        }
    }
}