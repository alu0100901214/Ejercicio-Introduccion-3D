using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Notifier notificador;

    public GameObject actualGoal;

    public float speed;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(actualGoal.transform.position);
        notificador.OnFuga += moreSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(this.transform.position,direction,Color.red);
        direction = actualGoal.transform.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    public void changeGoal(GameObject g)
    {
        actualGoal = g;
    }

    void moreSpeed()
    {
        speed += 10;
    }
}
