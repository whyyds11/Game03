using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camrea : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    Vector3 pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x= Player.position.x;
        pos.z = -10;
        pos.y = 3;
        transform.position = pos;
    }
}
