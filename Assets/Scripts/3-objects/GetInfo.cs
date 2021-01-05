using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetInfo : MonoBehaviour
{
    [SerializeField] Text infoForPlayer;
    [SerializeField] public int PointForOneStar = 0;


    // Start is called before the first frame update
    void Start()
    {
        infoForPlayer.text = "Your level score: " + OnTriggerPlayer.Score;
    }


    // Update is called once per frame
    void Update()
    {
        if(OnTriggerPlayer.Score< PointForOneStar)
        {
            infoForPlayer.text = "Your score is low!\nTry again :(\n";
        }


    }
}
