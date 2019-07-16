using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemyColision : MonoBehaviour
{
    public int damage = 1;
    public int speed;
    public GameObject effect;
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }


    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<playerMove>().health -= damage;
            Debug.Log(other.GetComponent<playerMove>().health);
            Destroy(gameObject);
        }
    }
}
