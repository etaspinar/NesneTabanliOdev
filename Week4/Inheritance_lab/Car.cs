namespace Inheritance_lab
{
    public class Car : Vehicle
    {
        public Car(double engine, int numberOfWeel, string model, int price, string transmission)
        {
            Engine = engine;
            NumberOfWeel = numberOfWeel;
            Model = model;
            Price = price;
            Transmission = transmission;
        }

        public override string? ToString()
        {
            return $"{Engine}\n{Model}\n{NumberOfWeel}\n{Transmission}\n{Price}";
        }
    }
}
