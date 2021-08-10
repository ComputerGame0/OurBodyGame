using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelTooth : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] public int NumOfBlack = 0;

    void Start()
    {
        NumOfBlack = Tooth_Trigger.NumOfBlack;
    }
    void Update()
    {
        NumOfBlack = Tooth_Trigger.NumOfBlack;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            if (NumOfBlack < 1)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
