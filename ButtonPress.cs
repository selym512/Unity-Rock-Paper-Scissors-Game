using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using battle;
using System;
using enemy;

public class ButtonPress : MonoBehaviour {

    public float buttonsize = 10;
    private Vector3 playerScale;
    int pChoice = 0;
   // public static enemydata enemy = new enemydata();
   // public static winning match = .AddComponent<winning>();

    int enemyD;

   
    private void Start()
    {
        playerScale = transform.localScale;

    }

    void Update () {

        //enemyD = enemydata.GetD();
        enemyD = enemydata.GetD();


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit))
            {
                if(hit.transform.name == gameObject.name)
                {
                transform.localScale = (transform.localScale * buttonsize );
                    if (gameObject.name == "Rock") { pChoice = 1; }
                    else if (gameObject.name == "Paper") { pChoice = 2; }
                    else /*(gameObject.name == "bluescissors")*/ { pChoice = 3; }
                    winning.Match(pChoice, enemydata.GetD());
                    //ChangeSprite.X();
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.localScale = playerScale;
            

            
        }
        


    }
}
