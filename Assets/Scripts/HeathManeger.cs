using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeathManeger : MonoBehaviour
{
    public float maxHealth;
    public float r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        r = Mathf.Clamp(r, 0, maxHealth);
        if(r<=0)
        {
            r = 0;
            Destroy(gameObject);
        }
    }
}
