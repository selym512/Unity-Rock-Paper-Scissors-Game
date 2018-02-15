using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace battle
{
    public class enemydata : MonoBehaviour
    {
        static int decision;


        public static void Turn()
        {
            decision = Random.Range(1, 3);
        }
      

        public static int GetD()
        {
            return decision;
        }
        public static void SetD(int D)
        {
            decision = D;

        }


        void Start()
        {
            decision = Random.Range(1, 3);
        }


        void Update()
        {

        }

      
    }
}