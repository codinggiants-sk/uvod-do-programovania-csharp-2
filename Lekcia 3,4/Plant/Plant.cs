namespace Plant
{
    class Plant
    {
        static int NumberOfPlants;
        int Height;
        int Age;
        string Type;
        public Plant(int height, int age, string type)

        {
            NumberOfPlants += 1;
            this.Height = height;
            this.Age = age;
            this.Type = type;
        }
        public static int GetNumberOfPlants()
        {
            return NumberOfPlants;
        }

    }
}
