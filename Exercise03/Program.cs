using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            var newImages = new Images();
            
            Console.WriteLine("Enter the width");
            var width= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > 200 && height < 150)
            {
                newImages.Potrait();
            }
            else
            {
                newImages.Landscape();
            }
        }
    }
}
