using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Console.WriteLine("Test of part 2...");
            FruitBox aBox = new FruitBox(1.75, 1.25);
            Console.WriteLine(aBox.GetBoxContentDescription());

            aBox.AddBananas(12);
            aBox.AddApples(7);
            Console.WriteLine(aBox.GetBoxContentDescription());


            Console.WriteLine("Test of part 3...");
            Console.WriteLine("The total cost is : {0}", aBox.GetTotalPrice());


            Console.WriteLine("Test of part 4...");
            aBox.SetPriceForOneBanana(1.50);
            aBox.SetPriceForOneApple(1.10);
            Console.WriteLine("The total cost is : {0}", aBox.GetTotalPrice());


            // The LAST line of code should be ABOVE this line
        }
    }
}
