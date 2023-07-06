using ProxyPattern;
namespace ProxyPatternTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProxyListing_GetDiffFromPendingToActive()
        {
            //Arrange
            IChangeTracking IListing = new ProxyListing();

            //Act
            String result =IListing.GetDiff("Pending", "Active");

            //Assert
            Assert.AreEqual("Listing detail is changed from Pending to Active", result);

        }
    }
}