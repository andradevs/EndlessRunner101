using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Vector2 targertPos;
    public float Yincrement;
    public float speed;
    public float minHeight;
    public float maxHeight;
    public GameObject effect;


    public int health = 100;

    private void Update(){
        transform.position = Vector2.MoveTowards(transform.position, targertPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targertPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);

        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targertPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);


        }
    }


}

