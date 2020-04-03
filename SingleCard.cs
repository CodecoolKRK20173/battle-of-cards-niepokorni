namespace CardGame
{
    public class SingleCard
    {
        public string CarModel { get; set; }
        public string EngineCapacity { get; set; }
        public string MaxSpeed { get; set; }
        public string Acceleration { get; set; }
        public string EnginePower { get; set; }
        
        //koncepcja dla Oli
        //private SingleCardView _singleCardView;
        
        
        public SingleCard(string carModel, string engineCapacity, string maxSpeed, string acceleration, string enginePower)
        {
            CarModel = carModel;
            EngineCapacity = engineCapacity;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            EnginePower = enginePower;
            
        }
    }
}