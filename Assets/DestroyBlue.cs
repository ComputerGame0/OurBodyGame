using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DestroyBlue : MonoBehaviour
{
    [SerializeField] string triggerblue;
    [SerializeField] public static int numofBlue = 8;
    [SerializeField] public Text ScoreWhite = null;

    public static int Scorewhite;
    public static int flag=0;
    



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Scorewhite = OnTriggerPlayer.Scorewhite;
    }
    void OnTriggerEnter(Collider collision)
    {
        
        if (collision.tag == triggerblue)
        {
            flag = 1;
            Debug.Log("player is in");
            Scorewhite--;
            OnTriggerPlayer.Scorewhite = OnTriggerPlayer.Scorewhite - 1;
            ScoreWhite.text = "" + Scorewhite;
            Destroy(collision.gameObject);
            numofBlue--;
           
        }
    }
   

}
