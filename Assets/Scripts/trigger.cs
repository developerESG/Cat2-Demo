using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public void Activator()
    {
        GetComponent<Animator>().SetBool("noPulse", false);

    }

    public void DeActivator()
    {
        GetComponent<Animator>().SetBool("noPulse", true);

    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }

}
