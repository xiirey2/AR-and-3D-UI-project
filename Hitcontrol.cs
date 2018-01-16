using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Hitcontrol1 : MonoBehaviour
{
    public GameObject obj;
    public Text scr;
    //private Hitcontrol2 hit2; 
    //private Hitcontrol3 hit3;
    public Button mybutt;
    private int count1 = 0;
    private int count2 = 0;
    private int count3 = 0;
    private int count = 0;
    private int final = 0;
    private bool hitted = false;
   // public int score1 = 0;
  public Movement1 movement1;
   //rivate Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        Button btn = mybutt.GetComponent<Button>();
        btn.onClick.AddListener(Des);

    }
    private void Update()
    {
        Vector3 pos = obj.transform.localPosition;
        if (pos.z >= 3.5 && pos.z <= 5)
        {
            movement1.GetComponent<Rigidbody>().isKinematic = true;
            FindObjectOfType<Gamecontrol1>().Gameover();
        }
    }


    void Gamecontrol()
    {
        
        Vector3 pos = obj.transform.localPosition;
        if (pos.z > -5 && pos.z <= -2)
        {
            if (hitted)
            {
                count1++;


            }
            if (count1 > 1 )
            {
              //movement1.enabled = false;
                movement1.GetComponent<Rigidbody>().isKinematic = true;
                FindObjectOfType<Gamecontrol1>().Gameover();

            }
        }
        else if (pos.z > -2 && pos.z <= 1)
        {
            if (hitted)
            {
                count2++;
                
            }
            if (count2 > 1)
            {
                movement1.GetComponent<Rigidbody>().isKinematic = true;
                FindObjectOfType<Gamecontrol1>().Gameover();

            }
            else { count2 += count1; }
        }
        else if (pos.z > 1 && pos.z <= 5)
        {
            if (hitted)
            {
                count3++;
             

            }
            if (count3 > 1)
            {
                movement1.GetComponent<Rigidbody>().isKinematic = true;
                FindObjectOfType<Gamecontrol1>().Gameover();

            }
            else { final = count3 += count2; }
            if (final==3)
            {
                count = final;
            }


        }

    }

    public void Des()
    {
        hitted = true;
        Gamecontrol();
        Vector3 pos = obj.transform.localPosition;
        //count = count1 + count2 + count3;


        if (count > 3)
        {
            movement1.GetComponent<Rigidbody>().isKinematic = true;
            FindObjectOfType<Gamecontrol1>().Gameover();
        }
        else if (count == 3)
        {
            Destroy(obj);
            Scoring.score++;

            scr.text = "your score is " + Scoring.score.ToString();
           // Debug.Log("Great! your currunt points is" + Scoring.score.ToString());
            if (Scoring.score == 3)
            {
                SceneManager.LoadScene("level2");
            }
        }
        
    }
}
