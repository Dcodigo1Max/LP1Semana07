using System;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        private string Name{get;}


        public Hero(string Name)
        {
            this.Name = Name;
        }



        public int XP
        {
            get
            {
                return xp;
            }
            set
            {
                xp = value; 
            }
        }




        
    
    
    }






}