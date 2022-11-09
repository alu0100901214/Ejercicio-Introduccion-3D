using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject nextGoal;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Follow>().changeGoal(nextGoal);
    }
}
