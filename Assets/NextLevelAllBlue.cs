using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelAllBlue : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] public int NumOfBlue = 0;



    void Start()
    {
        NumOfBlue = DestroyBlue.numofBlue;
    }
    void Update()
    {
        NumOfBlue = DestroyBlue.numofBlue;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            if (NumOfBlue == 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
