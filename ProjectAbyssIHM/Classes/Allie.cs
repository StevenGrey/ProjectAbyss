using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAbyss
{
    class Allie : Character
    {
        /*Attributs*/
        public string color { get; set; }

        /*Méthodes*/
        //Contructeurs
        public Allie()
        {            
        }

        public Allie(string color, int ip)
        {
            this.color = color;
            this.ip = ip;
        }

        //Méthodes
        
    }
}
