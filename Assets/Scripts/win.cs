using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject p1win;
    public GameObject p2win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F4))
        {
            SceneManager.LoadScene("Sample Scene");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="p1")
        {
            p1win.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.tag == "p2")
        {
            p2win.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
