using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NextLevel : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
   
    void start()
    {
       
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}