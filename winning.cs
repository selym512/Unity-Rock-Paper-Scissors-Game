using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using battle;

namespace battle
{

    public class winning : MonoBehaviour
    {
        static int wins = 0;
        static int loss = 0;
        static int tie = 0;
        public static int getWins()
        {
            return wins;
        }
        public static int getLoss()
        {
            return loss;
        }
        //static int selection;

        void Start()
        {

        }

        void Update()
        {
       

        }

        

        public static void Match(int selection, int eSelection)
        {
            switch (selection)
            {
                case 1:
                    if (eSelection == 2) { loss++;  }
                    else if (eSelection == 3) { wins++; }
                    else if (eSelection == 1) { tie++;  }
                    enemydata.Turn();
                    break;
                case 2:
                    if (eSelection == 3) { loss++; }
                    else if (eSelection == 1) { wins++; }
                    else if (eSelection == 2) { tie++; }
                    enemydata.Turn();
                    break;
                case 3:
                    if (eSelection == 1) { loss++;   }
                    else if (eSelection == 2) { wins++;  }
                    else if (eSelection == 3) { tie++;  }
                    enemydata.Turn();
                    break;

            }
            
        }
        

    }
}