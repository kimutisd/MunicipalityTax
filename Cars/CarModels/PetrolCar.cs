namespace Cars.CarModels
{
    internal class PetrolCar
    {
        public PetrolCar(string licenseNumber)
        {
            LicenseNumber = licenseNumber;
        }

        public string LicenseNumber { get; set; }
    }
}