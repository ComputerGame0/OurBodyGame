using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextLevelWrongLeg : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject player;

    [SerializeField] Text wrongLeg;
    [SerializeField] float Show_time = 2f;
    public static int flag = 0;


    void start()
    {
        StartCoroutine(ShowMessage(Show_time, sceneName));
    }
    void update()
    {
        StartCoroutine(ShowMessage(Show_time, sceneName));
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            Debug.Log("player");

            flag = 1;
            StartCoroutine(ShowMessage(Show_time, sceneName));


        }
    }
    IEnumerator ShowMessage(float delay, string sceneName)
    {

        if (flag == 1)
        {
            Destroy(player.GetComponent<CharacterKeyboardMover>());
            wrongLeg.text = "Wrong Hand";
            yield return new WaitForSeconds(delay);
            OnTriggerPlayer.Score = 0;
            OnTriggerPlayer.Scorewhite = 0;
            wrongLeg.text = "";
            SceneManager.LoadScene(sceneName);
        }


    }
}
