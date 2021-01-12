using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetInfo : MonoBehaviour
{
    [SerializeField] Text infoForPlayer;
    [SerializeField] public int PointForOneStar = 0;
    public int show = 0;

    // Start is called before the first frame update
    void Start()
    {
        show = OnTriggerPlayer.Score + OnTriggerPlayer.Scorewhite * 2;
        infoForPlayer.text = "Your level score: " + show;
    }


    // Update is called once per frame
    void Update()
    {
        if(show <= PointForOneStar)
        {
            infoForPlayer.text = "Your score is low!\nTry again :(\n";
        }


    }
}
