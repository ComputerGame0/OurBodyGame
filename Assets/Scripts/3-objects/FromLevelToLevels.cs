using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FromLevelToLevels : MonoBehaviour
{
    public int Score = 0;
    [SerializeField] public string sceneName=null;
     [SerializeField] public string sceneNamePass=null;
    [SerializeField] float Show_time = 2f;
    public int wholeScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        wholeScore = OnTriggerPlayer.Score+ OnTriggerPlayer.Scorewhite*2;
        Score = wholeScore;
        Debug.Log("ScoreLevel 3="+ Score);
        if (Score >= 8)
        {
            StartCoroutine(ShowMessage(Show_time, sceneNamePass));
        }
        else
        {
            StartCoroutine(ShowMessage(Show_time, sceneName));
        }
    }
    IEnumerator ShowMessage(float delay, string sceneNamenext)
    {
        yield return new WaitForSeconds(delay);
        Debug.Log("name= " + sceneNamenext);
        OnTriggerPlayer.Score = 0;
        OnTriggerPlayer.Scorewhite = 0;
        SceneManager.LoadScene(sceneNamenext);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
