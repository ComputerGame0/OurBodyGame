using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Fail : MonoBehaviour
{
    [SerializeField] Text infoForPlayer;
    public static int Scorewhite;
    [SerializeField] public string sceneNamePass = null;

    [SerializeField] float Show_time = 2f;
    public int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        Scorewhite = OnTriggerPlayer.Scorewhite;
        StartCoroutine(ShowMessage(Show_time, sceneNamePass));
    }

    // Update is called once per frame
    void Update()
    {
        Scorewhite = OnTriggerPlayer.Scorewhite;
        flag = DestroyBlue.flag;
        StartCoroutine(ShowMessage(Show_time, sceneNamePass));

    }
    IEnumerator ShowMessage(float delay, string sceneNamenext)
    {
        
        if (Scorewhite == -1&& flag==1)
        {
            Destroy(this.GetComponent<CharacterKeyboardMover>());
            infoForPlayer.text = "You have not collected enough white blood cells\nThe bacteria killed you!";
            yield return new WaitForSeconds(delay);
            OnTriggerPlayer.Score = 0;
            OnTriggerPlayer.Scorewhite = 0;
            infoForPlayer.text = "";
            DestroyBlue.flag = 0;
            SceneManager.LoadScene(sceneNamenext);
        }
     

    }
   
    
}
