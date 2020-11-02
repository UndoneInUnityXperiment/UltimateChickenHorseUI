using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManageer : MonoBehaviour
{
    public Canvas scoreCanvas;
    public GameObject goal, solo, coin, trap, first;
    public Transform spawnPos;

    // Update is called once per frame
    void Update()
    {
        //Press 'G' to add a goal to the score
        if(Input.GetKeyDown(KeyCode.G))
        {
            AddGoalScore();
        }
        //Press 'S' to add a solo to the score
        if (Input.GetKeyDown(KeyCode.S))
        {
            AddSoloScore();
        }
        //Press 'C' to add a coin to the score
        if (Input.GetKeyDown(KeyCode.C))
        {
            AddCoinScore();
        }
        //Press 'T' to add a trap to the score
        if (Input.GetKeyDown(KeyCode.T))
        {
            AddTrapScore();
        }
        //Press 'F' to add a first to the score
        if (Input.GetKeyDown(KeyCode.F))
        {
            AddFirstScore();
        }
    }

    void AddGoalScore()
    {
        GameObject newScore = Instantiate(goal);
        newScore.transform.localPosition = spawnPos.localPosition;
        newScore.transform.SetParent(scoreCanvas.transform, false);
        spawnPos.localPosition = spawnPos.localPosition + new Vector3(goal.transform.GetComponent<RectTransform>().rect.width, 0, 0);
    }

    void AddSoloScore()
    {
        GameObject newScore = Instantiate(solo);
        newScore.transform.localPosition = spawnPos.localPosition;
        newScore.transform.SetParent(scoreCanvas.transform, false);
        spawnPos.localPosition = spawnPos.localPosition + new Vector3(solo.transform.GetComponent<RectTransform>().rect.width, 0, 0);
    }

    void AddCoinScore()
    {
        GameObject newScore = Instantiate(coin);
        newScore.transform.localPosition = spawnPos.localPosition;
        newScore.transform.SetParent(scoreCanvas.transform, false);
        spawnPos.localPosition = spawnPos.localPosition + new Vector3(coin.transform.GetComponent<RectTransform>().rect.width, 0, 0);
    }

    void AddTrapScore()
    {
        GameObject newScore = Instantiate(trap);
        newScore.transform.localPosition = spawnPos.localPosition;
        newScore.transform.SetParent(scoreCanvas.transform, false);
        spawnPos.localPosition = spawnPos.localPosition + new Vector3(trap.transform.GetComponent<RectTransform>().rect.width, 0, 0);
    }

    void AddFirstScore()
    {
        GameObject newScore = Instantiate(first);
        newScore.transform.localPosition = spawnPos.localPosition;
        newScore.transform.SetParent(scoreCanvas.transform, false);
        spawnPos.localPosition = spawnPos.localPosition + new Vector3(first.transform.GetComponent<RectTransform>().rect.width, 0, 0);
    }
}
