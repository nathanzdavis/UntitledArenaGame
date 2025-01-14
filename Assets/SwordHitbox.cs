using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public GameObject currentTarget;
    public bool inTarget;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            return;

        if (other.transform.tag == "Enemy")
        {
            inTarget = true;
            currentTarget = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            inTarget = false;
            currentTarget = null;
        }
    }

    void Update()
    {
        if (currentTarget && currentTarget.GetComponent<MonsterController>().health <= 0)
        {
            currentTarget = null;
        }
    }
}
