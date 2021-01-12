using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    //[SerializeField] public TextMeshProUGUI scoreText;
    //[SerializeField] public TextMeshProUGUI LiveText;

    protected int currentScore = 0;
    protected int PlayerLife = 0;

    public int InitialPlayerLife;
    public int PointsPerBrick;

    private void Start()
    {
        ResetPlayer();
        UpdateUI();
    }

    private void ResetPlayer()
    {
        PlayerLife = InitialPlayerLife;
        currentScore = 0;
    }

    public void UpdateUI()
    {
        //scoreText.text = currentScore.ToString();
        //LiveText.text = PlayerLife.ToString();
    }

}
