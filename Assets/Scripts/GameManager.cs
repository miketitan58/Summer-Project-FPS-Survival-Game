using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        Debug.Log("Game starting, loading Scene 1");
        SceneManager.LoadScene(1);
    }

    public void ExitGame(){
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
