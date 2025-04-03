using System;
using System.Security.Cryptography.X509Certificates;

namespace ColorSpheres
{
    public class Program
    {
        private byte RED = 50;
        private byte GREEN =100;
        private byte BLUE = 120;
        private byte Alpha;

        public Program(byte RED, byte BLUE, byte GREEN, byte Alpha)
        {
            this.RED=RED;
            RED =Convert.ToByte(255);
            this.BLUE=BLUE;
            this.GREEN=GREEN;
            this.Alpha=Alpha;

        }   

        private static void Main(string[] args)
        {           
            
            
           
        }
    

        public byte GetRED()
        {
            return RED;
        }

        public byte GetBLUE()
        {
            return BLUE;
        }

        public byte GetGREEN()
        {
            return GREEN;
        }

        public byte GetAlpha()
        {
            return Alpha;
        }



    }  
}