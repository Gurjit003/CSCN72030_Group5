namespace ApplianceUnitTests
{
    [TestClass]
    public class ApplianceTests
    {
        [TestMethod]
        public void PowerSwitchFromFalse_ReturnTrue()
        {
            //Arrange
            Grill grill = new Grill();

            //act
            grill.PowerSwitch();

            //Assert
            Assert.IsTrue(grill.getPowerStatus());
        }

        [TestMethod]
        public void SetTemperature_equal10()
        {
            //Arrange
            Grill grill = new Grill();
            int result = 10;

            //Act
            grill.setTemp(10);

            //Assert
            Assert.AreEqual(result, grill.getTemperature());

        }

        [TestMethod]
        public void BreakDownOrder1Hamburger1Salad1pop()
        {
            int[] expectedResult = { 2, 1, 2, 1, 2, 1 };
            int[] result;

            Order[] order = new Order[3];
            order[0].main = "Hamburger";
            order[0].side = "Salad";
            order[0].drink = "Pop";

            order[1].main = "Hamburger";
            order[1].side = "Fries";
            order[1].drink = "Pop";

            order[2].main = "Chicken Burger";
            order[2].side = "Salad";
            order[2].drink = "Water";

            Kitchen kitchen = new Kitchen();
            kitchen.reciveOrder(order);
        }
    }
}