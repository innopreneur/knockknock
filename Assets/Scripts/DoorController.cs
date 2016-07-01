using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class DoorController : MonoBehaviour {


    public int doorId;

    private Transform myTransform;
    private Vector3 originalPos, openDoorPos;
    private Stopwatch timer;
    private int doorOpenTime;
    private bool isOpen;

	// Use this for initialization
	void Start () {

        timer = new Stopwatch();
        doorOpenTime = GameManager.instance.doorOpenTime;
        LevelManager.instance.listOfDoors.Add(this);

        myTransform = GetComponent<Transform>();
        originalPos = myTransform.position;
        openDoorPos = new Vector3(originalPos.x + 3.8f, originalPos.y, originalPos.z);
    }
	
    void Update()
    {
        if(isOpen)
        {
            timer.Start();

            if (timer.Elapsed.Seconds >= doorOpenTime)
            {
                CloseDoor();
                timer.Stop();
                timer.Reset();
            }
            
        }
        
    }

    public void OpenDoor()
    {
        myTransform.position = openDoorPos;
        LevelManager.instance.isDoorOpen = true;
        isOpen = true;

    }

    private void CloseDoor()
    {
        myTransform.position = originalPos;
        LevelManager.instance.isDoorOpen = false;
        isOpen = false;
    }
}
