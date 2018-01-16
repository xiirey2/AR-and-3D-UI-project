using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamecontrol1 : MonoBehaviour
{
    public float Restartdelay;
    public Text over;
    bool gameended;
    public void Gameover()
    {
        if(gameended==false)
        {
            gameended = true;
            over.text = "game over";
            //Debug.Log("Game over");

            Invoke("Restart", Restartdelay);

            // Restart();
        }


    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

