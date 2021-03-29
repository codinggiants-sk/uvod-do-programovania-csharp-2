using System;

namespace Cellphones
{
   
    class Cellphone
    {
        public int displayHeight;
        public int displayWidth;
        public int weight; 
        public string brand; 
        public string model; 
        public void ring ()
        {
            Console.WriteLine("Zvoním... "); 

        }
        public void sendSMS ()
        {
            Console.WriteLine("Posielam SMS... "); 

        }
        public Cellphone ( int height , int width , int phoneWeight, string brand, string phoneModel)
        {

            weight = phoneWeight;
            displayWidth = width;
            displayHeight = height;
            this.brand = brand;
            model = phoneModel; 
        }
}
}
