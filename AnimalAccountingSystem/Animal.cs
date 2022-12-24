namespace AnimalAccountingSystem
{
    public class Animal
    {
        private string _weight;
        private string _height;
        private string _foodType;

        public Animal(string weight, string height, string foodType)
        {
            _weight = weight;
            _height = height;
            _foodType = foodType;
        }

        public string GetWeight() => _weight;
        public string GetHeight() => _height;
        public string GetFoodType() => _foodType;
    }
}