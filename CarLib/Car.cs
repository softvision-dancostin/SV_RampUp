using System;

namespace CarLibrary
{
    public enum EngineState
    {
        engineAlive,
        engineDead
    }

    public abstract class Car
    {
        public Car()
        {
        }

        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }

        protected string petName;
        protected int currentSpeed;
        protected int maxSpeed;
        protected EngineState egnState = EngineState.engineAlive;

        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }
        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public EngineState EngineState
        {
            get { return egnState; }
        }

        public abstract void TurboBoost();
    }
}