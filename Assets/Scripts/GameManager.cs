using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    public static bool gameover;
    public int Lives = 1;
    public void Start()
    {
        GameOverPanel.SetActive(false);
    }
    public void KillPlayer()
    {
        Debug.Log("Kill Player");
        Lives -= 1;

        //Get Score From ScoreKeeper


        //Add Score To Score Board


        //Reset The Level 
        if (Lives<=0)
        {

            HighScoreManage.Scores.Add(FindObjectOfType<ScoreKeeper>().score);
            //HighScoreManager.SetHighscore();
            GameOverPanel.SetActive(true);
            //ReloadLevel();
        }

    }

    public void ReloadLevel()
    {
        int CurentSceneIs = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(CurentSceneIs);
    }
}
