using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform creator;
    public float ShootTime;
    public float timer;
    public Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if 
            (Input.GetMouseButtonDown(0)&& timer > ShootTime)
        {
            timer = 0;
            //timer = Time.time;
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bullet, creator.position, creator.rotation).GetComponent<Bullet>().direction = new Vector2(mousePosition.x - creator.transform.position.x, mousePosition.y - creator.transform.position.y).normalized;
            //Instantiate(bullet, creator.position,creator.rotation).GetComponent<Bullet>().face=GetComponent<PlayTurn>().face;
        }
    }
}
