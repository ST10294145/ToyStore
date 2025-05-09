using System;

class Toys
{
    public void toyList()
    {
          /* This is the list of toys offered to the custommer.
             More toys can be added in for more variety. */
         List<string> toyList = new List<string>();
            toyList.Add("Nerf Gun");
            toyList.Add("Hotwheel");
            toyList.Add("Lego");
            toyList.Add("Playstation 5");
            toyList.Add("Barbie Doll");
            toyList.Add("Remote Control Car");
            toyList.Add("Board Game");
            toyList.Add("Teddy Bear");


            Console.WriteLine("Here's our toy list:");
                foreach (string toy in toyList)
                {
                    Console.WriteLine(toy);
                }
    }
}