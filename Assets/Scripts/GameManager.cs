using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int timeTillNextDoor = 3;
    public int enemyWaitingTime = 1;
    public int totalEnemiesToHit = 10;
    public int doorOpenTime = 3;

    public static GameManager instance;

	void Awake () {

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
