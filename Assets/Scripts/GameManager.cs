using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variables
    [SerializeField] public int health = 100;
    [SerializeField] public int currentLevel = 1;
    [SerializeField] private int numZombies = 2;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject healthPowerup;
    public GameObject[] spawnpoints;
    
    // Start is called before the first frame update
    void Start()
    {
        StartWave(numZombies);
    }

    // Update is called once per frame
    void Update()
    {
        // If health hits 0, trigger a Game Over
        if (health <= 0)
            TriggerGameOver();


        // If player manages to escape the map
        if (player.transform.position.y < 0)
            TriggerGameOver();
    }

    // Start the wave
    public void StartWave(int numZombiesPerWave)
    {
        // increment level
        currentLevel++;
        // TODO: spawn zombies
        
        // spawn health powerups
        //if (Random.Range(0,2) == 1)
            Instantiate(healthPowerup, spawnpoints[Random.Range(0, spawnpoints.Length)].transform.position + new Vector3(Random.Range(-4, 4), 1.5f, Random.Range(-4, 4)), Quaternion.identity);
    }

    public void StartGame(){
        Debug.Log("Game starting, loading Scene 1");
        SceneManager.LoadScene(1);
    }

    // Game Over 
    public void TriggerGameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // Load Game Over Scene
        SceneManager.LoadScene(2);
    }

    public void ExitGame(){
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
