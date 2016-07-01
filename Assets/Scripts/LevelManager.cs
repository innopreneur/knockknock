using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{

    [HideInInspector]
    public static LevelManager instance;

    [HideInInspector]
    public bool shouldOpenDoor = false;

    [HideInInspector]
    public bool isDoorOpen = false;

    [HideInInspector]
    public bool shouldCloseDoor = false;

    [HideInInspector]
    public int enemiesHitCount = 0;

    [HideInInspector]
    public bool enemyHit = false;

    public List<DoorController> listOfDoors;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }

        listOfDoors = new List<DoorController>();
    }

    void Start()
    {
        foreach (DoorController d in listOfDoors)
        {
            Debug.Log("name - " + d.gameObject.name);
            Debug.Log("id - " + d.doorId);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //open door only if no other door is open
        if (!isDoorOpen)
        {
            //if it's time to open door, then open door
            if (shouldOpenDoor)
            {
                int x = Random.Range(0, listOfDoors.Count);
                Debug.Log("Open door - " + x);
                listOfDoors[x].OpenDoor();
                shouldOpenDoor = false;

            }
        }


    }
}
