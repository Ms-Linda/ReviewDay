using System;
namespace Review15
{
    public class Numbers
    {
        public Numbers()
        {
        }


        public int x { get; set; } = 100;

        public string Name { get; set; }




        public static int Add(int x, int y)
        {
            return x + y;
        }

        public void SayName()
        {
            Console.WriteLine(Name);
        }

        public bool LikesIceCream()
        {
            return true;
        }


        public string MakeUpperCase(string x)
        {
            return x.ToUpper();
        }

    }
}
