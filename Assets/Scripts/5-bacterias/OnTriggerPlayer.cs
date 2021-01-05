using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OnTriggerPlayer : MonoBehaviour
{

    [SerializeField] string triggeringTag_good;
    [SerializeField] string triggeringTag_bad;
    [SerializeField] string triggeringTag_double;

    [SerializeField] string sceneName;

    [SerializeField] public GameObject[] Heart=new GameObject[3];
    /*
    [SerializeField] GameObject heartLeft;
    [SerializeField] GameObject heartRight;
    [SerializeField] GameObject heartMiddle;
    */
    [SerializeField] public Text Score_Text = null;
    public static int Score;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag_double)
        {

            Destroy(collision.gameObject);
            Score = Score + 2;
            Score_Text.text = "Score:" + Score;
        }
        if (collision.tag == triggeringTag_good)
        {
           
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            Score = Score + 1;
            Score_Text.text = "Score:" + Score;
        }
        if (collision.tag == triggeringTag_bad)
        {
        
            if (Heart[0] != null) 
            {
                Destroy(Heart[0].gameObject);
            }
            else
            {
               
                if (Heart[1] != null)   
                {
                    
                    Destroy(Heart[1].gameObject);
                }
                else
                {
                    if (Heart[2] != null)
                    {
                      
                        Destroy(Heart[2].gameObject);
                        Score = 0;
                        SceneManager.LoadScene(sceneName);
                    }
                }
            }
          

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
