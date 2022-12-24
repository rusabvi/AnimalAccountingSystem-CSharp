namespace AnimalAccountingSystem
{
    public class AnimalList : List<Animal>
    {
        public new void Sort()
        {
            this.OrderBy((Animal animal) =>
                animal.GetWeight() +
                animal.GetHeight() +
                animal.GetFoodType()).ToList();
        }

        public override bool Equals(object? obj)
        {
            if (this == obj)
                return true;

            if (this == null && obj == null)
                return true;

            if (this == null || obj == null)
                return false;

            if (!(obj is AnimalList))
                return false;

            var other = (AnimalList)obj;

            if (this.Count != other.Count)
                return false;

            foreach (var animal1 in this)
            {
                bool equal = false;
                foreach (var animal2 in other)
                    if (animal1.Equals(animal2))
                    {
                        equal = true;
                        break;
                    }
                if (!equal)
                    return false;
            }    

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 19;
            foreach (var animal in this)
            {
                hash = hash * 31 + animal.GetHashCode();
            }
            return hash;
        }
    }
}