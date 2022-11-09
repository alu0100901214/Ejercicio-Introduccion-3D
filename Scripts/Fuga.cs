using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuga : MonoBehaviour
{

    public Notifier notificador;
    public GameObject egg;
    public bool huir = false;
    private Vector3 direction;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        notificador.OnFuga += moveToEgg;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (huir)
        {
            Debug.DrawRay(this.transform.position, direction, Color.red);
            direction = egg.transform.position - this.transform.position;
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }

    void moveToEgg()
    {
        huir = true;
    }
}
