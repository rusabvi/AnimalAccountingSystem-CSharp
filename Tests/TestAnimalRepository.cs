using AnimalAccountingSystem;

namespace Tests
{
    [TestClass]
    public class TestAnimalRepository
    {
        [TestMethod]
        public void FindByWeight1()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var weight = "heavy";
            var toChooseThis = true;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[0]);
            expectedAnimals.Add(animals[1]);

            // Act
            var resultAnimals = animalRepository.FindByWeight(weight, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByWeight2()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var weight = "heavy";
            var toChooseThis = false;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[2]);
            expectedAnimals.Add(animals[3]);

            // Act
            var resultAnimals = animalRepository.FindByWeight(weight, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByWeight3()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var weight = "mid";
            var toChooseThis = true;
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = animalRepository.FindByWeight(weight, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByHeight1()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            string height = "little";
            bool toChooseThis = true;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[0]);
            expectedAnimals.Add(animals[2]);

            // Act
            var resultAnimals = animalRepository.FindByHeight(height, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByHeight2()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var height = "little";
            var toChooseThis = false;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[1]);
            expectedAnimals.Add(animals[3]);

            // Act
            var resultAnimals = animalRepository.FindByHeight(height, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByHeight3()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var height = "heavy";
            var toChooseThis = true;
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = animalRepository.FindByHeight(height, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByFoodType1()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var foodType = "grass";
            var toChooseThis = true;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[1]);
            expectedAnimals.Add(animals[3]);

            // Act
            var resultAnimals = animalRepository.FindByFoodType(foodType, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByFoodType2()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var foodType = "grass";
            var toChooseThis = false;
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[0]);
            expectedAnimals.Add(animals[2]);

            // Act
            var resultAnimals = animalRepository.FindByFoodType(foodType, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void FindByFoodType3()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animalRepository.SetAnimals(animals);
            var foodType = "mid";
            var toChooseThis = true;
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = animalRepository.FindByFoodType(foodType, toChooseThis);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }
    }
}