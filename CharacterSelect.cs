using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace players
{
    public class CharacterSelect : MonoBehaviour
    {
        public static int player = 1;

        public static int GetP()
        {
            return player;
        }


        // public GameObject select;
        // ChangeSprite button;


        void Start()
        {
            //  button = select.GetComponent<ChangeSprite>();

        }

        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == gameObject.name)
                    {

                       // paperSwitch.SetObject

                        
                        if (player == 1)
                        {
                            player++;
                        }
                        else
                        {
                            player--;
                        }
                        

                    }
                }
            }
        }
    }
}