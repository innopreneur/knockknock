using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class EnemyController : MonoBehaviour {

    private Stopwatch wait;

    void Awake()
    {
        wait = new Stopwatch();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (LevelManager.instance.isDoorOpen)
        {
            wait.Start();

            if(wait.Elapsed.Seconds >= GameManager.instance.enemyWaitingTime && !LevelManager.instance.enemyHit)
            {
                UnityEngine.Debug.Log("Enemy says BOOOOOM!!!");
                wait.Stop();
                wait.Reset();
                wait.Start();

                if (wait.Elapsed.Seconds >= 4)
                {
                    LevelManager.instance.shouldCloseDoor = true;
                }
            }


            if (LevelManager.instance.enemyHit)
            {
                UnityEngine.Debug.Log("Enemy Died Painfully !!!!");
                wait.Stop();
                wait.Reset();
                wait.Start();
                if (wait.Elapsed.Seconds >= 1)
                {
                    LevelManager.instance.shouldCloseDoor = true;
                }
            }
        }

       
	}
}
