using System;
namespace Review15
{
    public class Animal
    {
        public Animal()
        {
        }


        public string Name { get; set; }
        public int Age { get; set; }

        public string Noise { get; set; }



        public void MakeNoise()
        {
            Console.WriteLine($"{Name} makes sound: {Noise}");
        }
    }
}
