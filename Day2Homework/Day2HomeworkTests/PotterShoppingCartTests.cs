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
        public void CheckOut_FirstEpisode_1_SecondEpisode_1_Others_0_Should_Return_190()
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

        [TestMethod]
        public void CheckOut_FirstEpisode_1_SecondEpisode_1_ThirdEpisode_1_Others_0_Should_Return_270()
        {
            // arrange
            const int expected = 270;
            var books = new[]
            {
                new HarryPotter {Episode = HarryPotterEpisode.First},
                new HarryPotter {Episode = HarryPotterEpisode.Second},
                new HarryPotter {Episode = HarryPotterEpisode.Third}
            };

            var target = new PotterShoppingCart();

            // act
            var actual = target.CheckOut(books);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOut_FirstEpisode_1_SecondEpisode_1_ThirdEpisode_1_FourthEpisode_1_FifthEpisode_0_Should_Return_320()
        {
            // arrange
            const int expected = 320;
            var books = new[]
            {
                new HarryPotter {Episode = HarryPotterEpisode.First},
                new HarryPotter {Episode = HarryPotterEpisode.Second},
                new HarryPotter {Episode = HarryPotterEpisode.Third},
                new HarryPotter {Episode = HarryPotterEpisode.Fourth}
            };

            var target = new PotterShoppingCart();

            // act
            var actual = target.CheckOut(books);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOut_FirstEpisode_1_SecondEpisode_1_ThirdEpisode_1_FourthEpisode_1_FifthEpisode_1_Should_Return_375()
        {
            // arrange
            const int expected = 375;
            var books = new[]
            {
                new HarryPotter {Episode = HarryPotterEpisode.First},
                new HarryPotter {Episode = HarryPotterEpisode.Second},
                new HarryPotter {Episode = HarryPotterEpisode.Third},
                new HarryPotter {Episode = HarryPotterEpisode.Fourth},
                new HarryPotter {Episode = HarryPotterEpisode.Fifth}
            };

            var target = new PotterShoppingCart();

            // act
            var actual = target.CheckOut(books);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
