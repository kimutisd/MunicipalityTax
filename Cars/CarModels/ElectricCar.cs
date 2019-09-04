namespace Cars.CarModels
{
    internal class ElectricCar
    {
        public ElectricCar(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
        }

        public string LicenseNumber { get; set; }
    }
}