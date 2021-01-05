﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ShowStars : MonoBehaviour
{
    public int Score = 0;
    [SerializeField] public int PointForOneStar = 0;
    [SerializeField] public int PointForTwoStars = 0;
    [SerializeField] public int PointForThreeStars = 0;

    [SerializeField] public GameObject OneStar = null;
    [SerializeField] public GameObject TwoStar = null;
    [SerializeField] public GameObject ThreeStar = null;
  
    // Start is called before the first frame update
    void Start()
    {
        Score = OnTriggerPlayer.Score;
        OneStar.SetActive(false);
        TwoStar.SetActive(false);
        ThreeStar.SetActive(false);
        if (Score >= PointForOneStar && Score < PointForTwoStars)
        {
            OneStar.SetActive(true);
        }
        else
        if (Score >= PointForTwoStars && Score < PointForThreeStars)
        {
            OneStar.SetActive(true);
            TwoStar.SetActive(true);
          
        }
        else
        if (Score >= PointForThreeStars)
        {
            OneStar.SetActive(true);
            TwoStar.SetActive(true);
            ThreeStar.SetActive(true);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
  
}