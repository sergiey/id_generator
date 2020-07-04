using System;

namespace id_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratorID zkid = new GeneratorID();

            foreach (var item in zkid.GetIDList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
