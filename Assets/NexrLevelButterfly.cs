using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NexrLevelButterfly : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject Butterfly;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag)
        {
            Debug.Log(Butterfly.transform.rotation.z);
            if (Butterfly.transform.rotation.z < 0)
            {
                
                SceneManager.LoadScene(sceneName);
            }
            
        }
    }
}
