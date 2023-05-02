
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JimmyLinq
{
    public static class ComicAnalyzer
    {
        private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
        {
            return prices[comic.Issue] > 100 ? PriceRange.Expensive : PriceRange.Cheap;

        }

        public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, IReadOnlyDictionary<int, decimal> prices)
        {
            //Method Chaining
            var groupComic = comics
                .OrderBy(comic => prices[comic.Issue])
                .GroupBy(comic => CalculatePriceRange(comic, prices));
            //Declarative Linq query
            //from comic in comics
            //orderby prices[comic.Issue]
            //group comic by CalculatePriceRange(comic,prices) into priceGroup
            //select priceGroup;


            return groupComic;
        }

        public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
        {
            //Method Chaining
            var grouped = comics
                .OrderBy(comic => comic.Issue)
                .Join(
                reviews,
                comic => comic.Issue,
                review => review.Issue,
                (comic, review) => 
                        $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}");
            //Declarative Linq query
                //from comic in comics
                //orderby comic.Issue
                //join review in reviews
                //on comic.Issue equals review.Issue
                //select
                //    $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";

            return grouped;
        }
        
    }
}
