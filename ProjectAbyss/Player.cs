using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAbyss
{
    class Player
    {
        /*Attributs*/
        public string name { get; set; }
        public int sumLocation { get; set; }
        public int sumLord { get; set; }
        public int sumAllies { get; set; }
        public int sumMonster { get; private set; }
        public int result { get; private set; }

        public List<Location> locations = new List<Location>();     //Lieu

        //Listes de Personnages        
        public List<Lord> lords = new List <Lord>();                //Seigneurs        
        public Allie[] allies = new Allie[5];                       //Alliés 

        /*Méthodes*/
        //Constructeurs
        public Player()
        {

        }

        public Player(string name, List<Lord> lords, int sumMonster)
        {
            this.name = name;            
            this.sumMonster = sumMonster;
            this.lords = lords;

            this.sumLocation = 0;
            this.sumLord = 0;            
        }

        //Actions
        public void ResultCalculation() //Calcul du Résultat Final
        {
            int sum = 0;

            foreach (Lord lord in lords)
                this.sumLord += lord.ip;

            sum += this.sumLord;
            sum += this.SumMaxAllies();
            sum += this.sumMonster;

            this.result = sum;
        }

        /*Récupération des max de chaque communauté*/
        public Allie MaxAllie(List<Allie> listAllies)
        {            
            Allie allieMax;

            if (listAllies.Count > 0)
            {
                allieMax = new Allie(listAllies[0].color, listAllies[0].ip);
                for (int i = 0; i < listAllies.Count; i++)
                {
                    if (listAllies[i].ip > allieMax.ip)                                            
                        allieMax = new Allie(listAllies[i].color, listAllies[i].ip);                                            
                }
            }
            else
                allieMax = new Allie();

            return allieMax;
        }

        /*Somme de l'ensemble des Alliés ayant les PI MAX*/
        private int SumMaxAllies()
        {
            this.sumAllies = 0;

            if (allies.Length > 0) {                                      
                foreach (Allie allie in allies)                
                    this.sumAllies += allie.ip;                
            }

            return this.sumAllies;
        }
        
    }
}
