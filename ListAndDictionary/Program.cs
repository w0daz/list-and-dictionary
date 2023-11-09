namespace ListAndDictionary
{
    internal class Program
    {
        // List variable containing names of persons
        private static List<string> personList = new List<string>();

        // Dictionary containing person name and age where the string TKey is for name and the int TValue is for age
        private static Dictionary<string, int> personAgeDictionary = new Dictionary<string, int>();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Person Manager!");
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add New Person");
                Console.WriteLine("2. Remove Person");
                Console.WriteLine("3. Find Person");
                Console.WriteLine("4. List All Persons");
                Console.WriteLine("5. Exit");

                string option = Console.ReadLine()!;
                switch (option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        RemovePerson();
                        break;
                    case "3":
                        FindPerson();
                        break;
                    case "4":
                        DisplayAllPersons();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }

        public static void AddPerson()
        {
            // TODO 1: Request user input for the person's name.
            // TODO 2: Validate if the person already exists in the personList.
            // TODO 3: Add the person to the personList if they don't already exist.
            // TODO 4: Provide user feedback for successful addition or if the person already exists in personList.
            // TODO 5: Validate if the person already exists in the personAgeDictionary.
            // TODO 6: If they don't exist, request age input and add the person to the personAgeDictionary.
            //         NOTE!: Remember to add both TKey and TValue
            // TODO 7: Provide user feedback for successful addition or if the person already exists in personAgeDictionary.

            Console.WriteLine("Please enter the name you will like to add:");
            string newname = Console.ReadLine()!;
            if (!personList.Contains(newname))
            {
                personList.Add(newname);
                Console.WriteLine($"{newname} has been added to the list");
                if (!personAgeDictionary.ContainsKey(newname))
                {
                    Console.WriteLine($"Please enter {newname}'s age:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    personAgeDictionary.Add(newname, age);
                    Console.WriteLine($"{newname}'s age has been added.");
                }
                else
                {
                    Console.WriteLine($"{newname} is already in the age directory.");
                }
            }
            else
            {
                Console.WriteLine($"{newname} is already on the list of names");
            }
        }

        public static void RemovePerson()
        {
            // TODO 8: Request user input for the name of the person to remove.
            // TODO 9: Remove the person from personList if they exist.
            // TODO 10: Provide user feedback for successful removal or if the person doesn't exist in personList.
            // TODO 11: Remove the person from personAgeDictionary if they exist.
            // TODO 12: Provide user feedback for successful removal or if the person doesn't exist in personAgeDictionary.

            Console.WriteLine("Please enter the name of the person you wish to remove:");
            string removename = Console.ReadLine()!;
            if (personList.Contains(removename))
            {
                personList.Remove(removename);
                Console.WriteLine($"{removename} has been deleted");
            }
            else
            {
                Console.WriteLine("This name doesn't exist in the list of names");
            }

            if (personAgeDictionary.ContainsKey(removename))
            {
                int age = personAgeDictionary[removename];
                personAgeDictionary.Remove(removename);
                Console.WriteLine($"{removename}'s age: ({age}) has been removed from the directory");
            }
            else
            {
                Console.WriteLine($"{removename} doesn't exist in the age directory");
            }
            
        }

        public static void FindPerson()
        {
            // TODO 13: Request user input for the name of the person to find.
            // TODO 14: Check if the person is in personList and provide appropriate feedback.
            // TODO 15: Check if the person is in personAgeDictionary and provide appropriate feedback.

            Console.WriteLine("Please enter the name of the person you will like to find:");
            string namesearch = Console.ReadLine()!;
            if (personList.Contains(namesearch))
            {
                Console.WriteLine($"Yes, {namesearch} is on the list of names:");
            }
            else
            {
                Console.WriteLine($"Sorry, {namesearch} cannot be found");
            }

            if (personAgeDictionary.ContainsKey(namesearch))
            {
                int age = personAgeDictionary[namesearch];
                Console.WriteLine($"{namesearch}" + ", " + age);
            }
            else
            {
                Console.WriteLine($"Sorry, {namesearch} cannot be found");
            }
        }

        public static void DisplayAllPersons()
        {
            // TODO 16: Iterate over personList and display each person's name.
            // TODO 17: Iterate over personAgeDictionary and display each person's name and age.
            // TODO 18: Consider handling the case where the lists are empty by providing feedback to the user.

            if (personList.Count > 0)
            {
                foreach (var name in personList)
                {
                    Console.WriteLine(name.ToString());
                }
            }
            else
            {
                Console.WriteLine("There are no names on the list");
            }

            if (personAgeDictionary.Count > 0)
            {
                foreach (var nameAge in personAgeDictionary)
                {
                    Console.WriteLine(nameAge.Key + " " + nameAge.Value);
                }
            }
            else
            {
                Console.WriteLine("There are no names and ages in the directory");
            }
        }
    }
}
