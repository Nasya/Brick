using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brick
{
    class GoThrough
    {
        public static void Comparison()
        {
            Item remote;
            Aperture window;
            bool key = OwnValues();

            if (key == true)
            {
                Console.WriteLine("Please enter item width:");
                int item_width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter item height:");
                int item_height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter item lenght:");
                int item_lenght = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter window width:");
                int window_width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter window height:");
                int window_height = Convert.ToInt32(Console.ReadLine());

                remote = new Item(item_width, item_height, item_lenght);
                window = new Aperture(window_width, window_height);

                Comp(remote, window);

                Console.ReadKey();
            }

            else
            {
                remote = new Item();
                window = new Aperture();
                Comp(remote, window);

                Console.ReadKey();
            }
        }

        public static bool OwnValues()
        {
            Console.WriteLine("Do you want to set your own values for item and window? Type Y. If you want to use default type N");
            string desicion = Console.ReadLine();
            if (desicion == "Y")
                return true;
            else return false;
        }

        public static void Comp(Item remote, Aperture window)
        {
            if (window.Width >= remote.Width)
                if (window.Height >= remote.Height)
                    Console.WriteLine("Your item went through this window");
                else Console.WriteLine("Height of your item too large");
            else Console.WriteLine("Width of your item too large");
        }
    }
}
