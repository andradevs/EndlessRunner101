using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tempo);
    }

    // Update is called once per frame
    

}
