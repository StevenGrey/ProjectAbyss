using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAbyss
{
    class Lord : Character
    {
        /*Attributs*/
        public string name { get; set; }
        

        /*Méthodes*/

        //Constructeurs
        public Lord(string name, string color, int ip)
        {
            this.name = name;
            this.color = color;
            this.ip = ip;
        }

        //Actions
    }
}
