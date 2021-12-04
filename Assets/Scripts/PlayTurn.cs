using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTurn : MonoBehaviour
{
    [HideInInspector] public int face = 1;
    [HideInInspector] public float inputX;
    [HideInInspector] public float scaleX;
    [HideInInspector] public float scaleY;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;

    }

    // Update is called once per frame
    void Update()
    {
        inputX = GetComponent<PlayerMove>().horizontalX;
        if (inputX * face < 0)
        {
            face *= -1;
        }
        transform.localScale = new Vector3(face * scaleX, scaleY, 1);
    }
}
