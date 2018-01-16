using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Home : MonoBehaviour {

    public Button bt;
   

    

    void Update()
    {
        Button b = bt.GetComponent<Button>();
        b.onClick.AddListener(Play);
    }
	public void Play()
    {
        
        SceneManager.LoadScene("level1", LoadSceneMode.Single);

    }
   

}
