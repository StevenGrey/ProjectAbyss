using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAbyss
{
    class Location
    {
        /*Attributs*/
        public string name { get; private set; }
        public string description { get; private set; }

        /*Constructeurs*/
        Location (string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
