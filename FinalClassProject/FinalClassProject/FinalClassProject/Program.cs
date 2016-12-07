using System;


namespace FinalClassProject

{
    public struct InventoryOfItem
    {
        public int ItemNumber;
        public string Description;
        public double PricePerItem;
        public int QuantityOnHand;
        public double OurCostPerItem;
        public double ValueOfItem;
    }

    class Program
    {
        static void Main()
        {
            var numberOfItemsSoFar = 0;
            var InventoryOfAllItems = new InventoryOfItem[100];
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.Write("A)dd C)hange D)elete L)ist Q)uit:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    
                    case "A":
                    case "a":
                        Console.Write("Item Number :");
                        string ItemNumber = Console.ReadLine();

                        Console.Write("Description :");
                        string Description = Console.ReadLine();

                        Console.Write("PricePerItem :");
                        string PricePerItem = Console.ReadLine();

                        Console.Write("QuantityOnHand :");
                        string QuantityOnHand = Console.ReadLine();

                        Console.Write("OurCostPerItem :");
                        string OurCostPerItem = Console.ReadLine();

                        InventoryOfAllItems[numberOfItemsSoFar].ItemNumber = Int32.Parse(ItemNumber);
                        InventoryOfAllItems[numberOfItemsSoFar].Description = Description;
                        InventoryOfAllItems[numberOfItemsSoFar].PricePerItem = Double.Parse(PricePerItem);
                        InventoryOfAllItems[numberOfItemsSoFar].QuantityOnHand = Int32.Parse(QuantityOnHand);
                        InventoryOfAllItems[numberOfItemsSoFar].OurCostPerItem = Double.Parse(OurCostPerItem);
                        InventoryOfAllItems[numberOfItemsSoFar].ValueOfItem = InventoryOfAllItems[numberOfItemsSoFar].PricePerItem
                            * InventoryOfAllItems[numberOfItemsSoFar].QuantityOnHand;

                        numberOfItemsSoFar++;
                        break;

                    
                    case "C":
                    case "c":
                        Console.Write("Item Number :");
                        string ItemNumber2 = Console.ReadLine();
                        int ItemNumberInt2 = Int32.Parse(ItemNumber2);

                        bool foundItem = false;
                        for (int i = 0; i < numberOfItemsSoFar; i++)
                        {
                            if (InventoryOfAllItems[i].ItemNumber == ItemNumberInt2)
                            {
                                
                                foundItem = true;
                                InventoryOfAllItems[i].QuantityOnHand++;
                                InventoryOfAllItems[i].ValueOfItem = InventoryOfAllItems[i].PricePerItem
                                    * InventoryOfAllItems[i].QuantityOnHand;
                            }
                        }
                        if (!foundItem)
                        {
                            Console.WriteLine("Item " + ItemNumber2 + " not found");
                        }
                        break;


                    case "D":
                    case "d":
                        Console.Write("Item Number :");
                        string ItemNumber3 = Console.ReadLine();
                        int ItemNumberInt3 = Int32.Parse(ItemNumber3);

                        bool foundItem3 = false;
                        for (int i = 0; i < numberOfItemsSoFar; i++)
                        {
                            if (InventoryOfAllItems[i].ItemNumber == ItemNumberInt3)
                            {
                                
                                foundItem3 = true;
                                InventoryOfAllItems[i].QuantityOnHand--;
                                InventoryOfAllItems[i].ValueOfItem = InventoryOfAllItems[i].PricePerItem
                                    * InventoryOfAllItems[i].QuantityOnHand;
                            }
                        }
                        if (!foundItem3)
                        {
                            Console.WriteLine("Item " + ItemNumber3 + " not found");
                        }
                        break;

                    case "L":
                    case "l":

                        if (numberOfItemsSoFar == 0)
                        {
                            Console.WriteLine("No items");
                        }

                        for (int index = 0; index < numberOfItemsSoFar; index++)
                        {
                            Console.WriteLine("ItemNumber : " + InventoryOfAllItems[index].ItemNumber);
                            Console.WriteLine("Description : " + InventoryOfAllItems[index].Description);
                            Console.WriteLine("PricePerItem : " + InventoryOfAllItems[index].PricePerItem);
                            Console.WriteLine("QuantityOnHand : " + InventoryOfAllItems[index].QuantityOnHand);
                            Console.WriteLine("OurCostPerItem : " + InventoryOfAllItems[index].OurCostPerItem);
                            Console.WriteLine("ValueOfItem : " + InventoryOfAllItems[index].ValueOfItem);
                            Console.WriteLine("------------------------");
                        }

                        break;


                    case "Q":
                    case "q":

                        
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp.Equals("y", StringComparison.OrdinalIgnoreCase))
                        {
                            keepGoing = false;
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Invalid option, try again");
                            break;
                        }
                }
            }
        }
    }
}


