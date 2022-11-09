using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;
    public float normalSpeed = 10f;
    public float turboSpeed = 20f;
    public float rotationSpeed = 100f;

    private Vector3 horizontal;
    
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime, 0);

    }

    public void setNormalSpeed(){
        speed = normalSpeed;
    }

    public void setTurboSpeed(){
        speed = turboSpeed;
    }
}
