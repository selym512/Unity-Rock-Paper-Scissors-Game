using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using battle;

public class winslosses : MonoBehaviour {

    public ParticleSystem particleLauncher;
    public Gradient particleColorGradient;


	void Start () {

    }


    void Update()
    {
        if (winning.getWins() < winning.getLoss())
        {
            ParticleSystem.MainModule psMain = particleLauncher.main;
            psMain.startColor = particleColorGradient.Evaluate(0);
        }
        else if (winning.getWins() > winning.getLoss())
        {
            ParticleSystem.MainModule psMain = particleLauncher.main;
            psMain.startColor = particleColorGradient.Evaluate(1);
        }
        else if (winning.getWins() == winning.getLoss())
        {
            ParticleSystem.MainModule psMain = particleLauncher.main;
            psMain.startColor = particleColorGradient.Evaluate(Random.Range(0f, 1f));
        }
        
    }
    public static void matchf(int result)
    {

        GameObject.FindWithTag("party");

           
    }
}
