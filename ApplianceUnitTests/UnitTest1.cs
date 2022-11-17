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
            Assert.IsTrue(grill.powerStatus);
        }
    }
}