using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
}
