using System;
using System.Dynamic;

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
        

        public int Level
        {
            get =>Level;
        }


        public float Health
        {
            get
            {
                return health;
            }
            set
            {
                if (health<0 )
                {
                    health = health + Health;
                }
                else if (health>140)
                {
                    health = health - Health;
                }

            }
        }




        
    
    
    }






}