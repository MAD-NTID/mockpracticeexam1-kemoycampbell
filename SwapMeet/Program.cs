const string BUSINESS_NAME = "Disks4Cheap";
Console.WriteLine(BUSINESS_NAME);

const double DISK_COST = 25.75;

Console.Write("Enter the inventory:");
int inventory;

//the input is an integer and is positive
if(int.TryParse(Console.ReadLine(), out inventory) && inventory >=0){
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Display Current inventory value");
    Console.WriteLine("2. Buy disks from " + BUSINESS_NAME);
    Console.WriteLine("3. Sell Disks to " + BUSINESS_NAME);
    Console.WriteLine("4. Exit");

    Console.Write("Choice:");
    switch(Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Total inventory: {0}, Total Cost:{1:C}", inventory, (inventory * DISK_COST));
        break;
        case "2":
            Console.Write("How many disk do you want to buy:");
            if(int.TryParse(Console.ReadLine(), out int buy) && buy<=inventory)
            {
                inventory = inventory - buy;
                //inventory-=buy; This is the same as inventory = inventory - buy
                Console.WriteLine("Total inventory: {0}, Total Cost:{1:C}", inventory, (inventory * DISK_COST));
            } else {
                Console.WriteLine("Please enter the number of disk(s) within the inventory amount");
            }
        break;
        case "3":
            Console.Write("How many disk(s) are you selling:");
            if(int.TryParse(Console.ReadLine(), out int sell) && sell >=0 )
            {
                inventory = inventory + sell;
                //inventory+=sell; same as inventory = inventory + sell;
                 Console.WriteLine("Total inventory: {0}, Total Cost:{1:C}", inventory, (inventory * DISK_COST));
            } else {
                Console.WriteLine("Please enter a positive amount!");
            }
        break;
        case "4":
            Console.WriteLine("Thank you for visiting us.");
        break;
        default:
            Console.WriteLine("Invalid choice. Please choose 1-4!");
        break;

    }

} else {
    //the input is not an integer
    Console.WriteLine("Please enter a positive number for  the inventory");
}



