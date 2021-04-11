using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text ScoreTextObject;
    public int score { get; private set; }

    private void Start()
    {
        AddToScore(0);
    }

    public void AddToScore(int ScoreToAdd)
    {

        if (GameManager.gameover == true)
        {
            Debug.Log("Unable to Add score Game is Over");
            return;
        }

            score += ScoreToAdd;

        if (ScoreTextObject != null)
        {
            ScoreTextObject.text = ArabicFixerTool.FixLine("امتیاز"+" : " + $"{score}");//$"SCORE : {score}";
        }
    }
}
