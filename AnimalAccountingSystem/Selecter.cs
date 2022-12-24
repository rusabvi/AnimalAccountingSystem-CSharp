namespace AnimalAccountingSystem
{
    public class Selecter
    {
        public static AnimalList SelectFrom(string pathToFile, AnimalRepository animalRepository)
        {
            string request = File.ReadAllText(pathToFile);
            return Select(animalRepository, request);
        }

        public static AnimalList Select(AnimalRepository animalRepository, string request)
        {                                                                   // "weight: not light or mid, height: high, foodType: grass"
            var animalsList = new List<AnimalList>();
            string[] subrequests = request.Split(", ");                     // ["weight: not light or mid", "height: high", "foodType: grass"]
            foreach (string subrequest in subrequests)                      // "weight: not light or mid"
            {
                var animals = new AnimalList();

                string[] wordPair = subrequest.Split(": ");                 // ["weight", "not light or mid"]
                string parameter = wordPair[0];                             // "weight"
                
                if (!parameter.Equals("weight") &&
                    !parameter.Equals("height") &&
                    !parameter.Equals("foodType"))
                    throw new FormatException("Wrong request");

                string[] values = wordPair[1].Split(" or ");                // ["not light", "mid"]
                foreach (string value in values)                            // "not light"
                {
                    bool toChooseThis = !value.Contains("not ");
                    string subvalue;

                    if (toChooseThis)
                        subvalue = value;

                    else
                        subvalue = value.Split("not ")[1];

                    if (parameter.Equals("weight"))
                        animals = OperateOr(animals,
                                            animalRepository.FindByWeight(subvalue, toChooseThis));

                    else if (parameter.Equals("height"))
                        animals = OperateOr(animals,
                                            animalRepository.FindByHeight(subvalue, toChooseThis));

                    else if (parameter.Equals("foodType"))
                        animals = OperateOr(animals,
                                            animalRepository.FindByFoodType(subvalue, toChooseThis));
                }

                animalsList.Add(animals);
            }

            AnimalList resultAnimals;

            try { resultAnimals = animalsList[0]; }
            catch { return new AnimalList(); }

            for (int i = 1; i < animalsList.Count; i++)
                resultAnimals = OperateAnd(resultAnimals, animalsList[i]);

            return resultAnimals;
        }

        public static AnimalList OperateAnd(AnimalList animals1, AnimalList animals2)
        {
            var resultAnimals = new AnimalList();
            foreach (var animal1 in animals1)
                foreach (var animal2 in animals2)
                    if (animal1.Equals(animal2))
                    {
                        resultAnimals.Add(animal1);
                        break;
                    }

            return resultAnimals;
        }
            

        public static AnimalList OperateOr(AnimalList animals1, AnimalList animals2)
        {
            var resultAnimals = new AnimalList();
            foreach (var animal in animals1)
                resultAnimals.Add(animal);

            foreach (var animal in animals2)
                if (!resultAnimals.Contains(animal))
                    resultAnimals.Add(animal);

            return resultAnimals;
        }
    }
}