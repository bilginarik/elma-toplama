using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_crtl : MonoBehaviour
{
    public GameObject Apple;

    private void Start()
    {
        InvokeRepeating("add_appl", 0.0f, 1.0f);
    }
    void add_appl()
    {
        float rnd = Random.Range(-2f, 14f);
        GameObject add_apple = Instantiate(Apple, new Vector3(rnd, 7, -7), Quaternion.identity);
    }
}
