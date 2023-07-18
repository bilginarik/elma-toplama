using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            float rnd = Random.Range(-2f, 14f);
            collision.gameObject.transform.position = new Vector3(rnd * Time.deltaTime, 7, -7);
        }
    }
}
