using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class ScoreManager : MonoBehaviour
{

    public static event Action OnPlayerEnd;
    public static event Action OnPlayerComplete;

    private int score;
    public TextMeshProUGUI textMeshProUGUI;
    private bool hasSpawned = false;

    [SerializeField]
    private int lifeRemaining = 3;

    public void ButtonClick()
    {
        if (hasSpawned == false)
        {
            score = Random.Range(1, 100);
            if (score >= 70)
            {
                textMeshProUGUI.text = score.ToString();
                hasSpawned = true;
                OnPlayerComplete?.Invoke();

            }
            else if (score < 70 )
            {
                lifeRemaining--;

                if (lifeRemaining == 0)
                {
                    OnPlayerEnd?.Invoke();
                }
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
