using System.Runtime.CompilerServices;
using ExcersiseSix;
using Moq;

namespace ExcersiseSixTest
{
    public class SecureDatabaseAccessProxyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AccessGranted_ReturnUserID()
        {
            //Arrange
            var proxy = new SecureDatabaseAccessProxy(new DatabaseAccess(), new UserPermissionService());
            string userId = "123";
            string expectedUserInfo = "User Info for 123";

            //Act
            string result = proxy.GetUserInfo(userId);

            //Assert
            Assert.AreEqual(expectedUserInfo,result);
        }

        [Test]
        public void AccessDenied_ThrowException()
        {
            //Arrange
            var proxy = new SecureDatabaseAccessProxy(new DatabaseAccess(), new UserPermissionService());
            string? userId = null;

            //Act&Assert
            Assert.Throws<UnauthorizedAccessException>(() => proxy.GetUserInfo(userId)); ;
        }
    }
}