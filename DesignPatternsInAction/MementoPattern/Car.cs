namespace MementoPattern
{
    public class Car
    {
        private int _fule;
        private int _speed;

        public Car()
        {

        }

        public Car(CarState state)
        {
            _fule = state.Fule;
            _speed = state.Speed;
        }
        public void AddFule(int value)
        {
            _fule += value;
        }

        public void IncreaseSpeed()
        {
            _speed++;
        }

        public void DecreaseSpeed()
        {
            _speed--;
        }

        public void Killometer()
        {
            _fule -= 6;
        }

        public CarState GetState()
        {
            return new CarState()
            {
                Fule = _fule,
                Speed = _speed
            };
        }
    }
}