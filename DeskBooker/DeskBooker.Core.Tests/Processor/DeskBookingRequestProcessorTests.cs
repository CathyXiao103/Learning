using DeskBooker.Core.DataInterface;
using DeskBooker.Core.Domain;
using Moq;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        private readonly DeskBookingRequest _request;
        private readonly Mock<IDeskBookingRepository> _deskBookingRepositoryMock;
        private readonly DeskBookingRequestProcessor _processor;
        public DeskBookingRequestProcessorTests()
        {
            _request = new DeskBookingRequest
            {
                FirstName = "Thomas",
                LastName = "Hunter",
                Email = "thomas@thomasclaudiushuber.com",
                Date = new DateTime(2020, 1, 28)

            };

            _deskBookingRepositoryMock = new Mock<IDeskBookingRepository>();
            _processor = new DeskBookingRequestProcessor(
                _deskBookingRepositoryMock.Object);
        }
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ShouldReturnDeskBookingResultWithRequestValues()
        {
            //Arrange


            //Act
            DeskBookingResult result = _processor.BookDesk(_request);

            //Assert
            Assert.NotNull(result);
            Assert.AreEqual(_request.FirstName, result.FirstName);
            Assert.AreEqual(_request.LastName, result.LastName);
            Assert.AreEqual(_request.Email, result.Email);
            Assert.AreEqual(_request.Date, result.Date);
        }

        [Test]
        public void ShouldThrowExceptionIfRequestIsNull()
        {

            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookDesk(null));

            Assert.AreEqual("request", exception.ParamName);
        }

        [Test]
        public void ShouldSaveDeskBooking()
        {
            DeskBooking saveDeskBooking = null;
            _deskBookingRepositoryMock.Setup(x => x.Save(It.IsAny<DeskBooking>()))
                .Callback<DeskBooking>(deskbooking =>
                {
                    saveDeskBooking = deskbooking;
                });
            _processor.BookDesk(_request);

            _deskBookingRepositoryMock.Verify(x=>x.Save(It.IsAny<DeskBooking>()),Times.Once);

            Assert.NotNull(saveDeskBooking);

            Assert.AreEqual(_request.FirstName, saveDeskBooking.FirstName);
            Assert.AreEqual(_request.LastName, saveDeskBooking.LastName);
            Assert.AreEqual(_request.Email, saveDeskBooking.Email);
            Assert.AreEqual(_request.Date, saveDeskBooking.Date);
        }

        [Test]
        public void ShouldNotSaveDeskBookingIfNoDeskAvailable()
        {
            _processor.BookDesk(_request);
            _deskBookingRepositoryMock.Verify( x=> x.Save(It.IsAny<DeskBooking>()),Times.Once);
        }
    }
}
