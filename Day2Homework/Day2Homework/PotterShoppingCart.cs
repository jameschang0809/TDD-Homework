using System;
using System.Linq;

namespace Day2Homework
{
    public class PotterShoppingCart
    {
        public double CheckOut(HarryPotter[] books)
        {
            var total = (double)books.Sum(x => x.Price);
            switch (books.Length)
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
                default:
                    throw new NotImplementedException();
            }

            return total;
        }
    }
}