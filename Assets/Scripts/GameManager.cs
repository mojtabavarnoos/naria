using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static bool gameover;
    public int Lives = 1;
    public void KillPlayer()
    {
        Lives -= 1;

        //Get Score From ScoreKeeper


        //Add Score To Score Board


        //Reset The Level 
        if (Lives<=0)
        {
            ReloadLevel();
        }

    }

    private static void ReloadLevel()
    {
        int CurentSceneIs = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(CurentSceneIs);
    }
}
