using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using battle;

namespace enemy
{

    public class EnemyChoice : MonoBehaviour
    {

        public Sprite sprite1, sprite2, sprite3, sprite4;
        public GameObject item;


        public void EnemyC()
        {
            if ((enemydata.GetD()) == 1)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;

            }
            else if ((enemydata.GetD()) == 2)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            else if ((enemydata.GetD()) == 3)
            {
                GetComponent<SpriteRenderer>().sprite = sprite3;
            }

           // Wait();
            GetComponent<SpriteRenderer>().sprite = sprite4;

        }

       


        void Start()
        {

        }

        void Update()
        {

        }
    }
}