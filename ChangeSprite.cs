using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using players;


    public class ChangeSprite : MonoBehaviour
    {

        public Sprite firstP;
        public Sprite SecondP;

        public static int character = 1;

        //public Sprite firstPX;
        //public Sprite SecondPX;
        //public static bool S1 = true;
        //public static bool S2 = true;
        //public

        /*
    static void X()
    {
        if (character == 1)
        {
            S1 = false;
        }
        if (character == 2)
        {
            S2 = false;
        }
    }
    */

    /*
    public void ChangeColor()
    {

    }
    */
    // Use this for initialization
    void Start()
        {
       
        }

        // Update is called once per frame
        void Update()
        {
        if (CharacterSelect.GetP() == 1)
        {
            GetComponent<SpriteRenderer>().sprite = firstP;
            /*
            character = 1;
            if (S1 == false)
            {
                GetComponent<SpriteRenderer>().sprite = firstPX;

            }
            */
        }
        if (CharacterSelect.GetP() == 2)
        {

            GetComponent<SpriteRenderer>().sprite = SecondP;
            /*
            character = 2;
            if (S2 == false)
            {
                GetComponent<SpriteRenderer>().sprite = SecondPX;

            }
            */
        }
        
    }
    }