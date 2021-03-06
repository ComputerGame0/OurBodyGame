﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToAllLevel : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] float delay = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowImage(delay));
    }

    IEnumerator ShowImage(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);

    }
}
