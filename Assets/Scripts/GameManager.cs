
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// to add a reference to UI
    public GameObject completeLevelUI;

    public float delay = 2f;
    bool gameHasEnded = false;


    public void CompleteLevel() // moves to next Level of game
    {
        completeLevelUI.SetActive(true);

    }


    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay); // adding a delay before restarting 

            Restart();

        }

    }

    void Restart() // restarts the game 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }






}
