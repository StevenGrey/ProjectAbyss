using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAbyss
{
    class Lord
    {
        /*Attributs*/
        public string name { get; set; }
        public string color { get; set; }
        public int ip { get; set; }

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
