using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{

    private int score;


    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void IncreaseScore()
    {
        score++;
       
    }

}
