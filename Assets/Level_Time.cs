using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Time : MonoBehaviour
{
    [SerializeField] public Text timerText;
    [SerializeField] public Text game_over;
    [SerializeField] string sceneName;
    [SerializeField] float Show_time = 2f;

    void Start()
    {
        StartCoroutine(reloadTimer(120));
    }


    IEnumerator reloadTimer(float reloadTimeInSeconds)
    {
        float counter = 0;

        while (counter < reloadTimeInSeconds)
        {
            Debug.Log((int)(reloadTimeInSeconds - counter));
            counter += Time.deltaTime;
            timerText.text = ((int)(reloadTimeInSeconds - counter)).ToString();
            yield return null;
        }

        StartCoroutine(ShowMessage(Show_time));

        //Load new Scene
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator ShowMessage(float delay)
    {
        timerText.text = "";
        game_over.text = "Game Over\n Time out:(";
        yield return new WaitForSeconds(delay);
        

    }
}
