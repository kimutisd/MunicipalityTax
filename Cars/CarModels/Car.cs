namespace Cars.CarModels
{
    internal class Car
    {
        public Car(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
        }

        public string LicenseNumber { get; set; }
    }
}