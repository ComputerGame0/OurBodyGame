using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class OnTriggerPlayer : MonoBehaviour
{

    [SerializeField] string triggeringTag_good;
    [SerializeField] string triggeringTag_bad;
    [SerializeField] string triggeringTag_white;

    [SerializeField] string sceneName;

    [SerializeField] public GameObject[] Heart=new GameObject[3];
    /*
    [SerializeField] GameObject heartLeft;
    [SerializeField] GameObject heartRight;
    [SerializeField] GameObject heartMiddle;
    */
    [SerializeField] public Text Score_Text = null;
    [SerializeField] public Text Score_Text_White = null;

    public static int Score;
    public static int Scorewhite;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == triggeringTag_white)
        {

            Destroy(collision.gameObject);
            Scorewhite = Scorewhite + 1;
            Score_Text_White.text = "" + Scorewhite;
        }
        if (collision.tag == triggeringTag_good)
        {
           
            Debug.Log(collision.gameObject.name);
            Destroy(collision.gameObject);
            Score = Score + 1;
            Score_Text.text = "" + Score;
        }
        if (collision.tag == triggeringTag_bad)
        {
        
            if (Heart[0] != null) 
            {
                Destroy(Heart[0].gameObject);
                Destroy(collision.gameObject);
            }
            else
            {
               
                if (Heart[1] != null)   
                {
                    
                    Destroy(Heart[1].gameObject);
                    Destroy(collision.gameObject);

                }
                else
                {
                    if (Heart[2] != null)
                    {
                      
                        Destroy(Heart[2].gameObject);
                        Destroy(collision.gameObject);
                        Score = 0;
                        Scorewhite = 0;
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
