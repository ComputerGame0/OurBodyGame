using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class On_Trigger_music : MonoBehaviour
{


    [SerializeField] string bad;
    [SerializeField] string sceneName;
    [SerializeField] public GameObject[] Heart = new GameObject[2];


    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.tag == bad)
        {
            Debug.Log("musiccc bad ######");
/*
            if (Heart[0] != null)
            {
                Debug.Log("heart1 ######");
                Destroy(Heart[0].gameObject);
            }
            else
            {

                if (Heart[1] != null)
                {
                    Debug.Log("heart2 ######");
                    Destroy(Heart[1].gameObject);
                    

                }
               
            }
*/
            SceneManager.LoadScene(sceneName);


        }

    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
