using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameoverscreen;

    public void addScore()
    {
        playerscore = playerscore + 1;
        scoretext.text = playerscore.ToString();
    }

    public void resetScore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}
