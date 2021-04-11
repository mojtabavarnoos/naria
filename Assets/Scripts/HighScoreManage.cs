using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManage : MonoBehaviour
{
    public GameObject HighScorePrefab;
    public static List<int> Scores = new List<int>();

    public void OnEnable()
    {
        if (Scores == null)
        {
            Debug.LogError("List Dose not Exist");
        }
        DestroyChildren();
        SetHighscore();
    }
    public void DestroyChildren()
    {
        foreach (var child in transform.GetComponentsInChildren<Transform>())
        {
            if (child == transform) continue;
            Destroy(child.gameObject);
        }

    }
    public void SetHighscore()
    {
        Scores.Sort();
        Scores.Reverse();
        Debug.Log("Start SetHighscore");
        foreach (var score in Scores)
        {
            GameObject obj = Instantiate(HighScorePrefab, transform) as GameObject;
            obj.name = $"ScoreTable {score}";
            Text Textobj = obj.GetComponent<Text>();
            if (Textobj != null)
            {
                Textobj.text = $"{score}";
            }
        }
    }

}
