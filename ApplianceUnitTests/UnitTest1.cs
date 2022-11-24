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
    }
}