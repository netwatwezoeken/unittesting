using AutoFixture;
using Moq;
using Vehicles;
using Xunit;

namespace AnswerPart2
{
    public class NotifyTax
    {
        [Fact]
        public void MessageIsSentToRegisteredEmailAddress()
        {
            var fixture = new Fixture();
            var emailaddress = fixture.Create<string>();
            var tax = fixture.Create<int>();

            var mailerMock = new Mock<IMailer>();
            var vehicleStub = new Mock<IVehicle>();
            vehicleStub.Setup(s => s.OwnerEmail).Returns(emailaddress);

            var calculator = new Mock<IVehicleTaxCalculator>();
            calculator.Setup(c => c.CalculateTax(vehicleStub.Object)).Returns(tax);

            var notify = new TaxNotification(calculator.Object, mailerMock.Object);

            notify.NotifyOwner(vehicleStub.Object);
            mailerMock.Verify(m => m.SendEmail(emailaddress, It.Is<string>(s => s.Contains(tax.ToString()))), Times.Once);
        }
    }
}
