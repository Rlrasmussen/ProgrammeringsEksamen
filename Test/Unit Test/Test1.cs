using Console_projekt;
namespace Unit_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestAddCollection()
        {
            //Arrange
            Calculater calculater = new Calculater();
            List<int> expected = new List<int>(new int[] {16, 10});

            //Act
            calculater.Adding(13, 3);
            calculater.Adding(9, 1);

            //Assert
            CollectionAssert.AreEqual(expected, calculater.Results);
        }

        [TestMethod]
        public void TestAdd()
        { 
        //Arrange
        Calculater calculater = new Calculater();
            int first = 10;
            int second = 15;
            int expected = 25;

            //Act
            int actual = calculater.Adding(first, second);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTicket()
        {
            //Arrange
            Train train = new Train();
            List<int> expected = new List<int>(new int[] { 0, 10, 20, 5 });

            //Act
            train.Ticketprice(1);
            train.Ticketprice(10);
            train.Ticketprice(25);
            train.Ticketprice(70);

            //Assert
            CollectionAssert.AreEqual(expected, train.Prices);
        }
    }
}
