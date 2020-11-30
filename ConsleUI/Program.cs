using System;
using Models;

namespace ConsleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new PersonModel()
            {
                FirstName = "Edward",
                LastName = "Ziemiński"
            };

            var przywitanie = $@"Hello { model.FirstName } { model.LastName }
            fgdfg gfdsgdf";
            
            Console.WriteLine(przywitanie);
            Console.WriteLine();
        }
    }
}
