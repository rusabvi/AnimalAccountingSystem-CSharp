using AnimalAccountingSystem;

namespace Tests
{
    [TestClass]
    public class TestSelecter
    {
        [TestMethod]
        public void OperateAnd1()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            for (int i = 0; i < 4; i++)
                animals2.Add(animals1[i]);
            var expectedAnimals = new AnimalList();
            for (int i = 0; i < 4; i++)
                expectedAnimals.Add(animals2[i]);

            // Act
            var resultAnimals = Selecter.OperateAnd(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateAnd2()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            animals2.Add(animals1[1]);
            animals2.Add(animals1[2]);
            animals2.Add(new Animal("heavy", "mid", "all"));
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals1[1]);
            expectedAnimals.Add(animals1[2]);

            // Act
            var resultAnimals = Selecter.OperateAnd(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateAnd3()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = Selecter.OperateAnd(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateAnd4()
        {
            // Array
            var animals1 = new AnimalList();
            var animals2 = new AnimalList();
            animals2.Add(new Animal("heavy", "little", "all"));
            animals2.Add(new Animal("heavy", "mid", "grass"));
            animals2.Add(new Animal("light", "little", "all"));
            animals2.Add(new Animal("light", "mid", "grass"));
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = Selecter.OperateAnd(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateOr1()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            for (int i = 0; i < 4; i++)
                animals2.Add(animals1[i]);
            var expectedAnimals = new AnimalList();
            for (int i = 0; i < 4; i++)
                expectedAnimals.Add(animals2[i]);

            // Act
            var resultAnimals = Selecter.OperateOr(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateOr2()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            animals2.Add(animals1[1]);
            animals2.Add(animals1[2]);
            animals2.Add(new Animal("heavy", "mid", "all"));
            var expectedAnimals = new AnimalList();
            for (int i = 0; i < 4; i++)
                expectedAnimals.Add(animals1[i]);
            expectedAnimals.Add(animals2[2]);

            // Act
            var resultAnimals = Selecter.OperateOr(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateOr3()
        {
            // Array
            var animals1 = new AnimalList();
            animals1.Add(new Animal("heavy", "little", "all"));
            animals1.Add(new Animal("heavy", "mid", "grass"));
            animals1.Add(new Animal("light", "little", "all"));
            animals1.Add(new Animal("light", "mid", "grass"));
            var animals2 = new AnimalList();
            var expectedAnimals = new AnimalList();
            for (int i = 0; i < 4; i++)
                expectedAnimals.Add(animals1[i]);

            // Act
            var resultAnimals = Selecter.OperateOr(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void OperateOr4()
        {
            // Array
            var animals1 = new AnimalList();
            var animals2 = new AnimalList();
            animals2.Add(new Animal("heavy", "little", "all"));
            animals2.Add(new Animal("heavy", "mid", "grass"));
            animals2.Add(new Animal("light", "little", "all"));
            animals2.Add(new Animal("light", "mid", "grass"));
            var expectedAnimals = new AnimalList();
            for (int i = 0; i < 4; i++)
                expectedAnimals.Add(animals2[i]);

            // Act
            var resultAnimals = Selecter.OperateOr(animals1, animals2);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void Select1()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "little", "grass"));
            animals.Add(new Animal("light", "little", "meat"));
            animals.Add(new Animal("light", "mid", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animals.Add(new Animal("light", "mid", "meat"));
            animals.Add(new Animal("light", "big", "all"));
            animals.Add(new Animal("light", "big", "grass"));
            animals.Add(new Animal("light", "big", "meat"));
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "little", "grass"));
            animals.Add(new Animal("heavy", "little", "meat"));
            animals.Add(new Animal("heavy", "mid", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("heavy", "mid", "meat"));
            animals.Add(new Animal("heavy", "big", "all"));
            animals.Add(new Animal("heavy", "big", "grass"));
            animals.Add(new Animal("heavy", "big", "meat"));
            animalRepository.SetAnimals(animals);
            var request = "weight: light, height: little, foodType: all";
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[0]);

            // Act
            var resultAnimals = Selecter.Select(animalRepository, request);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void Select2()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "little", "grass")); //1
            animals.Add(new Animal("light", "little", "meat")); //2
            animals.Add(new Animal("light", "mid", "all"));
            animals.Add(new Animal("light", "mid", "grass")); //4
            animals.Add(new Animal("light", "mid", "meat")); //5
            animals.Add(new Animal("light", "big", "all"));
            animals.Add(new Animal("light", "big", "grass"));
            animals.Add(new Animal("light", "big", "meat"));
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "little", "grass")); //10
            animals.Add(new Animal("heavy", "little", "meat")); //11
            animals.Add(new Animal("heavy", "mid", "all"));
            animals.Add(new Animal("heavy", "mid", "grass")); //13
            animals.Add(new Animal("heavy", "mid", "meat")); //14
            animals.Add(new Animal("heavy", "big", "all"));
            animals.Add(new Animal("heavy", "big", "grass"));
            animals.Add(new Animal("heavy", "big", "meat"));
            animalRepository.SetAnimals(animals);
            var request = "height: little or mid, foodType: not all";
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[1]);
            expectedAnimals.Add(animals[2]);
            expectedAnimals.Add(animals[4]);
            expectedAnimals.Add(animals[5]);
            expectedAnimals.Add(animals[10]);
            expectedAnimals.Add(animals[11]);
            expectedAnimals.Add(animals[13]);
            expectedAnimals.Add(animals[14]);

            // Act
            var resultAnimals = Selecter.Select(animalRepository, request);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void Select3()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "little", "grass"));
            animals.Add(new Animal("light", "little", "meat"));
            animals.Add(new Animal("light", "mid", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animals.Add(new Animal("light", "mid", "meat"));
            animals.Add(new Animal("light", "big", "all"));
            animals.Add(new Animal("light", "big", "grass"));
            animals.Add(new Animal("light", "big", "meat"));
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "little", "grass"));
            animals.Add(new Animal("heavy", "little", "meat"));
            animals.Add(new Animal("heavy", "mid", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("heavy", "mid", "meat"));
            animals.Add(new Animal("heavy", "big", "all"));
            animals.Add(new Animal("heavy", "big", "grass"));
            animals.Add(new Animal("heavy", "big", "meat"));
            animalRepository.SetAnimals(animals);
            var request = "height: little or mid, weight: heavy";
            var expectedAnimals = new AnimalList();
            for (int i = 9; i < 15; i++)
                expectedAnimals.Add(animals[i]);

            // Act
            var resultAnimals = Selecter.Select(animalRepository, request);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void Select4()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "little", "grass"));
            animals.Add(new Animal("light", "little", "meat"));
            animals.Add(new Animal("light", "mid", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animals.Add(new Animal("light", "mid", "meat"));
            animals.Add(new Animal("light", "big", "all"));
            animals.Add(new Animal("light", "big", "grass"));
            animals.Add(new Animal("light", "big", "meat"));
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "little", "grass"));
            animals.Add(new Animal("heavy", "little", "meat"));
            animals.Add(new Animal("heavy", "mid", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("heavy", "mid", "meat"));
            animals.Add(new Animal("heavy", "big", "all"));
            animals.Add(new Animal("heavy", "big", "grass"));
            animals.Add(new Animal("heavy", "big", "meat"));
            animalRepository.SetAnimals(animals);
            var request = "height: litTtle or miiid, weight: heaAavy, foodType: f";
            var expectedAnimals = new AnimalList();

            // Act
            var resultAnimals = Selecter.Select(animalRepository, request);

            // Assert
            Assert.AreEqual(expectedAnimals.Count, resultAnimals.Count);
        }

        [TestMethod]
        public void Select5()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animalRepository.SetAnimals(animals);
            var request = "weit: light, heit: little, fud tipe: all";

            // Act and Assert
            Assert.ThrowsException<FormatException>(() => Selecter.Select(animalRepository, request));
        }

        [TestMethod]
        public void SelectFrom1()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animals.Add(new Animal("light", "little", "all"));
            animals.Add(new Animal("light", "little", "grass"));
            animals.Add(new Animal("light", "little", "meat"));
            animals.Add(new Animal("light", "mid", "all"));
            animals.Add(new Animal("light", "mid", "grass"));
            animals.Add(new Animal("light", "mid", "meat"));
            animals.Add(new Animal("light", "big", "all"));
            animals.Add(new Animal("light", "big", "grass"));
            animals.Add(new Animal("light", "big", "meat"));
            animals.Add(new Animal("heavy", "little", "all"));
            animals.Add(new Animal("heavy", "little", "grass"));
            animals.Add(new Animal("heavy", "little", "meat"));
            animals.Add(new Animal("heavy", "mid", "all"));
            animals.Add(new Animal("heavy", "mid", "grass"));
            animals.Add(new Animal("heavy", "mid", "meat"));
            animals.Add(new Animal("heavy", "big", "all"));
            animals.Add(new Animal("heavy", "big", "grass"));
            animals.Add(new Animal("heavy", "big", "meat"));
            animalRepository.SetAnimals(animals);
            var pathToFile = @"..\..\..\Request.txt";
            var expectedAnimals = new AnimalList();
            expectedAnimals.Add(animals[0]);

            // Act
            var resultAnimals = Selecter.SelectFrom(pathToFile, animalRepository);

            // Assert
            Assert.AreEqual(expectedAnimals, resultAnimals);
        }

        [TestMethod]
        public void SelectFrom2()
        {
            // Array
            var animalRepository = new AnimalRepository();
            var animals = new AnimalList();
            animalRepository.SetAnimals(animals);
            var pathToFile = @"..\..\..\wrongPathToFile.txt";

            // Act and Assert
            Assert.ThrowsException<FileNotFoundException>(() => Selecter.SelectFrom(pathToFile, animalRepository));
        }
    }
}