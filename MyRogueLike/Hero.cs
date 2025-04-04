using System;
using System.Diagnostics.Tracing;
using System.Dynamic;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;
        private string Name{get;}

        private float MaxHealth{get;} = 140;


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

        public MaxHealth(float MaxHealth)
        {
            MaxHealth = 100 +(Level -1) * 20;
            return MaxHealth;
        }


        public void TakeDamage(float damage)
        {
            
        }




        
    
    
    }






}