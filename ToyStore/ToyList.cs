using System;

class Toys
{
    // This method displays a list of toys to the customer
    public void toyList()
    {
        /*
         * This is the list of toys offered to the customer.
         * More toys can be added below for greater variety.
         * We use a List<string> to easily manage and display the toy names.
         */

        List<string> toyList = new List<string>(); // Initialize a list to hold toy names

        // Add each toy to the list
        toyList.Add("Nerf Gun");
        toyList.Add("Hotwheel");
        toyList.Add("Lego");
        toyList.Add("Playstation 5");
        toyList.Add("Barbie Doll");
        toyList.Add("Remote Control Car");
        toyList.Add("Board Game");
        toyList.Add("Teddy Bear");

        // Output the toy list to the console
        Console.WriteLine("Here's our toy list:");

        // Loop through the list and print each toy name
        foreach (string toy in toyList)
        {
            Console.WriteLine(toy);
        }
    }
}