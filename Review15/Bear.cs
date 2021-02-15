using System;
namespace Review15
{
    public class Bear : IStandable, IRoarable
    {
        public Bear()
        {
        }

        public string Name { get; set; }

        public static int NumberOfBears;

        public bool CanStand { get; set; }

        public void Roaring()
        {
            Console.WriteLine("Roaring");
        }
    }
}
