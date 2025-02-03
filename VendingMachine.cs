using System;
using System.Windows.Forms;

namespace CoffeeMachineApp
{
    public class VendingMachine
    {
        public int Water { get; private set; }
        public int Coffee { get; private set; }
        public int Chocolate { get; private set; }
        public int Milk { get; private set; }

        public VendingMachine(int water, int coffee, int chocolate, int milk)
        {
            Water = water;
            Coffee = coffee;
            Chocolate = chocolate;
            Milk = milk;
        }

        public bool MakeCoffee()
        {
            if (Water >= 300 && Coffee >= 20)
            {
                Water -= 300;
                Coffee -= 20;
                return true;
            }
            return false;
        }

        public bool MakeMocha()
        {
            if (Water >= 300 && Coffee >= 20 && Chocolate >= 10)
            {
                Water -= 300;
                Coffee -= 20;
                Chocolate -= 10;
                return true;
            }
            return false;
        }

        public bool MakeLatte()
        {
            if (Water >= 300 && Coffee >= 20 && Milk >= 10)
            {
                Water -= 300;
                Coffee -= 20;
                Milk -= 10;
                return true;
            }
            return false;
        }

        public bool MakeChocolate()
        {
            if (Water >= 300 && Chocolate >= 20)
            {
                Water -= 300;
                Chocolate -= 20;
                return true;
            }
            return false;
        }

        public void Refill()
        {
            Water = 5000;
            Coffee = 1000;
            Chocolate = 1000;
            Milk = 1000;
        }
    }
}
