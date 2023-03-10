namespace FactoryPatternExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;

            do {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("What Database would you like to use: List, Mongo, or SQL?");

                userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput= false;
                    Console.WriteLine("Try again.");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);

            Console.Clear();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products)
            {
                Console.WriteLine($"Product: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
            }


        }
    }
}
