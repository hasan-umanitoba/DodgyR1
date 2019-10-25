using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTank : MonoBehaviour
{ // this Camera follows the tank ()

    public GameObject player;
    private Vector3 cameraPos = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraPos; //setting camera's position to players current position




    }
}
