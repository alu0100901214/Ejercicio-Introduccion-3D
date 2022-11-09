using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{
    public GameObject samurai;
    public delegate void fuga();
    public event fuga OnFuga;

    float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(samurai.transform.position, transform.position);
        if (distance <= 5)
        {
            OnFuga();
            Destroy(gameObject);
        }
    }

}
