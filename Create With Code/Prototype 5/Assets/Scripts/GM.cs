﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GM : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    private float spawnRate = 1.0f;
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        scoreText.text = "Score: " + score;
        UpdateScore(0);
    }

    IEnumerator SpawnTarget() 
    {
        while(true) 
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
            UpdateScore(pointValue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
