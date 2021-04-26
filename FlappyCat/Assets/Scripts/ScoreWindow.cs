using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreWindow : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private void Awake()
    {

    }

    private void Update()
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
    }
}
