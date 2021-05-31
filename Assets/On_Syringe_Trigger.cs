using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class On_Syringe_Trigger : MonoBehaviour
{

    
    [SerializeField]  GameObject Good1;
    [SerializeField]  GameObject Good2;
    [SerializeField]  GameObject Good3;
    [SerializeField] string triggeringTag_bad;
    [SerializeField] string triggeringTag_good;
    [SerializeField] string sceneName;
    public static int Score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("innnnnn ######");
        if (collision.tag == triggeringTag_bad)
        {
            Destroy(collision.gameObject);

            if (Good1.GetComponent<Renderer>().enabled == true)
            {
                Debug.Log("Good 1 ######");
                Good1.GetComponent<Renderer>().enabled = false;
                
            }
            else
            {

                if (Good2.GetComponent<Renderer>().enabled == true)
                {
                    Debug.Log("Good 2 ######");
                    Good2.GetComponent<Renderer>().enabled = false;

                }
                else
                {
                    if (Good3.GetComponent<Renderer>().enabled == true)
                    {
                        Debug.Log("Good 3 ######");
                        Good3.GetComponent<Renderer>().enabled = false;
                        SceneManager.LoadScene(sceneName);
                    }
                }
                
            }
           


        }
        if (collision.tag == triggeringTag_good)
        {
            
            Destroy(collision.gameObject);

            if (Good3.GetComponent<Renderer>().enabled == false)
            {
                Debug.Log("Good 3 ######");
                Good3.GetComponent<Renderer>().enabled = true;
            }
            else
            {

                if (Good2.GetComponent<Renderer>().enabled == false)
                {
                    Debug.Log("Good 2 ######");
                    Good2.GetComponent<Renderer>().enabled = true;
                    Score = 10;

                }
                else
                {
                    if (Good1.GetComponent<Renderer>().enabled == false)
                    {
                        Debug.Log("Good 1 ######");
                        Good1.GetComponent<Renderer>().enabled = true;
                        Score = 20;
                    }
                }
            }
            



        }
        

    }
}







