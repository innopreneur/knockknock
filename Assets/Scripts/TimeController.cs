using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class TimeController : MonoBehaviour {

    /*** inspector controlled varaibles ***/

    /*** in-game variables ***/
    private Stopwatch timer;
    private bool isStarted = false;

    void Awake()
    {
        timer = new Stopwatch();

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            isStarted = true;
        }

        if (isStarted)
        {
            timer.Start();
        }

        if(timer.Elapsed.Seconds % GameManager.instance.timeTillNextDoor == 0)
        {
            //open the door
            LevelManager.instance.shouldOpenDoor = true;
        }
	}
}
