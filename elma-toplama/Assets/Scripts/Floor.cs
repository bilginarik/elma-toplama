using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Floor : MonoBehaviour
{
    float health = 100.0f;
    float current_health = 100.0f;

    public GameObject pausePanel;
    public Image healthbar;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "apple")
        {
            Destroy(collision.gameObject);

            current_health -= 10.0f;
            healthbar.fillAmount = current_health / health;

            if (current_health <=0)
            {
                pausePanel.SetActive(true);
                Time.timeScale = 0.0f;
            }

        }
    }
}
