using System.Linq;

namespace AnimalAccountingSystem
{
    public class AnimalRepository
    {
        private AnimalList _animals;

        public AnimalRepository()
        {
            _animals = new AnimalList();
        }

        public AnimalList GetAnimals() => _animals;
        public void SetAnimals(AnimalList animals) => _animals = animals;

        public void SetAnimalsFrom(string pathToFile)
        {
            var text = File.ReadAllText(pathToFile);
            var lines = text.Split("\n");
            foreach (string line in lines)
            {
                var values = line.Split(", ");
                try { _animals.Add(new Animal(values[0], values[1], values[2])); }
                catch { throw new FormatException("Wrong dataset"); }
            }
        }

        public AnimalList FindByWeight(string weight, bool toChooseThis)
        {
            var animals = new AnimalList();
            foreach (Animal animal in _animals)
                if (animal.GetWeight().Equals(weight).Equals(toChooseThis))
                    animals.Add(animal);
            return animals;
        }

        public AnimalList FindByHeight(string height, bool toChooseThis)
        {
            var animals = new AnimalList();
            foreach (Animal animal in _animals)
                if (animal.GetHeight().Equals(height).Equals(toChooseThis))
                    animals.Add(animal);
            return animals;
        }

        public AnimalList FindByFoodType(string foodType, bool toChooseThis)
        {
            var animals = new AnimalList();
            foreach (Animal animal in _animals)
                if (animal.GetFoodType().Equals(foodType).Equals(toChooseThis))
                    animals.Add(animal);
            return animals;
        }
    }
}