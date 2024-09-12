using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        scoreText.text = "X " + score;
    }
}
