using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

    private Camera mainCam;
    public LayerMask mask;

	// Use this for initialization
	void Start () {

        mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressed mouse button");
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, mask))
            {
                Debug.Log("Hit - " + hit.collider.name);

                if (hit.collider.tag == "enemy")
                {
                    Debug.Log("Enemy Hit !!!!!");
                    LevelManager.instance.enemiesHitCount++;
                    LevelManager.instance.enemyHit = true;
                }
            }
        }
	}
}
