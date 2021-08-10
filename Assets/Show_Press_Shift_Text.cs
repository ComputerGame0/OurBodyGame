using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Press_Shift_Text : MonoBehaviour
{
    [SerializeField] public Text set1 = null;
    [SerializeField] float Show_time = 2f;
    int count_left_arrow = 1;
    int count_right_arrow = 1;
    static int count_shift = 1;
    void Start()
    {
        set1.text = "";
        StartCoroutine(ShowImage(Show_time));
    }
   

    IEnumerator ShowImage(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "Press Shift !";
        count_shift = 0;

    }
    IEnumerator ShowImage2(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "Press Leftarrow !";
        count_left_arrow = 0;


    }
    IEnumerator ShowImage3(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "Press \nRightarrow !";
        count_right_arrow = 0;

    }
    IEnumerator ShowImage4(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "";
        
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift) && count_shift==0)
        {
            Debug.Log("press shift");
            set1.text = "Great !\n Velocity=50";
            count_shift = 1;
            StartCoroutine(ShowImage2(Show_time));

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && count_left_arrow==0)
        {
            set1.text = "Good!";
            count_left_arrow = 1;
            StartCoroutine(ShowImage3(Show_time));


        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && count_right_arrow == 0)
        {
            set1.text = "Perfect!";
            count_right_arrow = 1;
            StartCoroutine(ShowImage4(Show_time));


        }

    }
}
