using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class Next_Level_DNA : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] public Text game_over;
    [SerializeField] float Show_time = 2f;

    void start()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            if (Turn_around_DNA.count_DNA1 == -1 && Turn_around_DNA2.count_DNA2 == -1 && Turn_around_DNA3.count_DNA3 == -1)
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                StartCoroutine(ShowMessage(Show_time));
            }
            
        }
    }

    IEnumerator ShowMessage(float delay)
    {
       
        game_over.text = "Fix all DNA !";
        yield return new WaitForSeconds(delay);
        game_over.text = "";


    }
}
