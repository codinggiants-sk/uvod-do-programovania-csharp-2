using System;

namespace HeroClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hero zaklinac = new Hero(30, 120, "Geralt", "Boj s mecom", 100, 40);
            zaklinac.DescribeYourself();
        }
    }
}