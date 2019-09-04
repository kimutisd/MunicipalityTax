namespace Cars
{
    using CarModels;

    public static class CarAgent
    {
        public static string GetLicenseNumber<T>(T inputCar)
        where T : class
        {
            switch (inputCar)
            {
                case Car car:
                    return car.LicenseNumber;
                case ElectricCar electricCar:
                    return electricCar.LicenseNumber;
                case PetrolCar petrolCar:
                    return petrolCar.LicenseNumber;
                default:
                    return null;
            }
        }
    }
}
