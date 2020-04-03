﻿namespace CardGame
{
    public class SingleCard
    {
        public string CarModel { get; set; }
        public int EngineCapacity { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        public int EnginePower { get; set; }
        
        //koncepcja dla Oli
        private SingleCardView _singleCardView;
        
        
        public SingleCard(string carModel, int engineCapacity, int maxSpeed, int acceleration, int enginePower)
        {
            CarModel = carModel;
            EngineCapacity = engineCapacity;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            EnginePower = enginePower;
            
        }
    }
}