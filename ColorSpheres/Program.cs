﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace ColorSpheres
{
    public class Color
    {
        private byte RED = 100;
        private byte GREEN = 40;
        private byte BLUE = 60;
        private byte Alpha = 255;
        private byte grey;

        public Color(byte RED, byte BLUE, byte GREEN, byte Alpha)
        {
            this.RED=RED;
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


        public byte GetGrey()
        {
            grey = Convert.ToByte((RED + BLUE + GREEN)/3);
            return grey;
        }


    }  
}