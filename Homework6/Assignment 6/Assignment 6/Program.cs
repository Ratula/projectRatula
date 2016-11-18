using System;

namespace ConsoleApplication1
{
    public struct Pet
    {
        public string Name;
        public string TypeOfPet;
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0; //Right now the database is empty, hence starting from zero
            var pets = new Pet[10]; //The database can hold upto 10 pets 

            while (true) //While loop - continuous 
            {
                Console.Write("A)dd D)elete L)ist pets:"); //The program is giving an option to add, delete, or list the pets in the database
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "A": //If the user chooses to add a pet to the database
                    case "a":
                        {
                            Console.Write("Name :"); // User needs to add the name of the pet
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :"); //User must say what type of pet it is
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name; //This is the code for the array 
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            numberOfPets++; //If a user keeps adding pets to the list, this is showing the increment 
                            break;
                        }

                    case "D": //If a user chooses to delete a pet from the database 
                    case "d":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets"); //If there are no pets added to the list yet
                                break;
                            }

                            for (var index = 0; index < numberOfPets; index++) //for loop showing the code for the list
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //Showing the list (a table of name and type) of pets
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); //User can enter the number of the pet to be removed from the list

                            var petNumberToDelete = Console.ReadLine();
                            var indexToDelete = int.Parse(petNumberToDelete); //the pet is now deleted from the list

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--; //the list now does not have the pet because it is removed

                            break;
                        }

                    case "L": //if the user chooses to see the list of pets already in the database 
                    case "l":
                        {
                            if (numberOfPets == 0)
                            {
                                Console.WriteLine("No pets"); //This shows up if there are no pets in the database
                            }

                            for (int index = 0; index < numberOfPets; index++)
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet); //the list of pets shows up if there are pets in the database
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option [{0}]", choice); //If the user selects an option more than 10 as the databse can hold upto 10 pet names and types
                            break;
                        }
                }
            }
        }
    }
}