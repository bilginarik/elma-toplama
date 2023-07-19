using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basket : MonoBehaviour
{
    public float Speed = 10f;
    int score = 0;
    public TextMeshProUGUI scoreText;

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "apple")
        {
            score += 10;
            scoreText.text = "Skor: " + score.ToString();
            Destroy(collision.gameObject);  

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Speed*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }
        
    }
}
