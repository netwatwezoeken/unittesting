namespace Vehicles
{
    public class TaxNotification
    {
        private readonly IVehicleTaxCalculator _taxCalculator;
        private readonly IMailer _mailer;

        public TaxNotification( IVehicleTaxCalculator taxCalculator, IMailer mailer)
        {
            _taxCalculator = taxCalculator;
            _mailer = mailer;
        }

        public void NotifyOwner(IVehicle vehicle)
        {
            _mailer.SendEmail(vehicle.OwnerEmail, _taxCalculator.CalculateTax(vehicle).ToString());
        }
    }
}