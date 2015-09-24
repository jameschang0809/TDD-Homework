using Day2Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2HomeworkTests
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void CheckOut_FirstEpisode_1_Others_0_Should_Return_100()
        {
            // arrange
            const int expected = 100;
            var books = new[]
            {
                new HarryPotter {Episode = HarryPotterEpisode.First}
            };

            var target = new PotterShoppingCart();

            // act
            var actual = target.CheckOut(books);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOut_FirstEpisode_1_SecondEpisode_2_Other_0_Should_Return_190()
        {
            // arrange
            const int expected = 190;
            var books = new[]
            {
                new HarryPotter {Episode = HarryPotterEpisode.First},
                new HarryPotter {Episode = HarryPotterEpisode.Second}
            };

            var target = new PotterShoppingCart();

            // act
            var actual = target.CheckOut(books);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
