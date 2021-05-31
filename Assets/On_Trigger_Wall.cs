using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class On_Trigger_Wall : MonoBehaviour
{
    [SerializeField] string Wall_Tag;
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.tag == Wall_Tag)
        {
            Debug.Log("wallll ######");
            SceneManager.LoadScene(sceneName);
        }
    }
}
