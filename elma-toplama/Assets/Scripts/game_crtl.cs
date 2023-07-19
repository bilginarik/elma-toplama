using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_crtl : MonoBehaviour
{
    public GameObject Apple;
    bool pauseGame = false;

    public void new_game()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
        Time.timeScale = 1.0f;
    }
    public void pause_game()
    {
        pauseGame =!pauseGame;
        if (pauseGame == true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }
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
