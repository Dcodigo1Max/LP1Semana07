using System;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ColorSpheres
{
    public class Color
    {
        private string name;
        private byte red = 50;
        private byte green = 100;
        private byte blue = 200;
        private byte alpha = 255;
        private byte grey;


       /* public ParaColor(string name)
        {
            this.name=name;
            
        }*/

        public Color(byte red, byte blue, byte green, byte alpha)
        {
            this.red=red;
            this.blue=blue;
            this.green=green;
            this.alpha=alpha;

        }   



        private static void Main(string[] args)
        {  
           /*      
           Console.WriteLine("Spawn sphere");
           Color red = Convert.ToString();
           red = Console.ReadLine();
           */
           
        }
    

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
            

        
    } 

    public class Spheres
    {
        private string cor;
        private float raio;
        private int Tthrown;

        
        
        
        public Spheres(string cor, float raio)
        {
            this.cor=cor;
            this.raio=raio;
            Tthrown=0;
        }   


        public void Pop()
        {
            raio=0;
            Console.WriteLine("Esfera foi furada");
        }

        public void Throw()
        {
           
           //count?
        }


        public void GetTimesThrown()
        {
           // return count;

        }



    }




}