using System;

namespace ColorSpheres
{
    
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
           if (raio>0)
           {
             Tthrown++;
           }
           
        }


        public void GetTimesThrown()
        {
           // return count;

        }
    


    }




}