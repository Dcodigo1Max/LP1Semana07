using System;

namespace BetterColorSpheres
{
    public class Color
    {
        private string name;
        private byte red = 50;
        private byte green = 100;
        private byte blue = 200;
        private byte alpha = 255;
        private byte grey;


                public byte GetRED()
        {
            return red;
        }

        public byte GetBLUE()
        {
            return blue;
        }

        public byte GetGREEN()
        {
            return green;
        }

        public byte GetAlpha()
        {
            return alpha;
        }


        public byte Grey => grey = Convert.ToByte((red + blue + green)/3);
            

        
    
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }
    }
}
