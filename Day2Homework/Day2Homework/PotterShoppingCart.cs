using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2Homework
{
    public class PotterShoppingCart
    {
        public double CheckOut(HarryPotter[] books)
        {
            var groupedBooks = new List<List<HarryPotter>>();
            foreach (var item in books.GroupBy(x => x.Episode))
            {
                var i = 0;
                foreach(var subItem in item)
                {
                    if (groupedBooks.Count == i)
                        groupedBooks.Add(new List<HarryPotter> {subItem});
                    else
                        groupedBooks[i].Add(subItem);

                    i++;
                }    
            }

            return groupedBooks.Sum(x => CalculateTotalPrice(x));
        }

        private static double CalculateTotalPrice(IEnumerable<HarryPotter> books)
        {
            var total = (double)books.Sum(x => x.Price);
            switch (books.Count())
            {
                case 1:
                    total *= 1;
                    break;
                case 2:
                    total *= 0.95;
                    break;
                case 3:
                    total *= 0.9;
                    break;
                case 4:
                    total *= 0.8;
                    break;
                case 5:
                    total *= 0.75;
                    break;
                default:
                    throw new NotImplementedException();
            }

            return total;
        }
    }
}