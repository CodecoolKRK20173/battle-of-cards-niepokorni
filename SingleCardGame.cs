using System.Collections.Generic;

namespace Niepokorni
{
    public class SingleCardGame
    {
        public string CarModel { get; set; }
        public int EngineCapacity { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        public int EnginePower { get; set; }

        
        public SingleCardGame(string carModel, int engineCapacity, int maxSpeed, int acceleration, int enginePower)
        {
            CarModel = carModel;
            EngineCapacity = engineCapacity;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            EnginePower = enginePower;
        }   
        
        
    }
}