using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Show_Message_DNA : MonoBehaviour
{
    [SerializeField] Text great_text;
    [SerializeField] float Show_time = 2f;
    // Start is called before the first frame update
    void Start()
    {
        if (Turn_around_DNA.count_DNA1 == 3 || Turn_around_DNA2.count_DNA2 == 3 || Turn_around_DNA3.count_DNA3 == 3)
        {
            StartCoroutine(ShowMessage(Show_time));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Turn_around_DNA.count_DNA1 == 3 || Turn_around_DNA2.count_DNA2 == 3 || Turn_around_DNA3.count_DNA3 == 3)
        {
            StartCoroutine(ShowMessage(Show_time));
        }
    }

    IEnumerator ShowMessage(float delay)
    {


        great_text.text = "Great";
            yield return new WaitForSeconds(delay);
        great_text.text = "";

        if (Turn_around_DNA.count_DNA1 == 3 )
        {
            Turn_around_DNA.count_DNA1 = -1;
        }
        if (Turn_around_DNA2.count_DNA2 == 3)
        {
            Turn_around_DNA2.count_DNA2 = -1;
        }
        if (Turn_around_DNA3.count_DNA3 == 3)
        {
            Turn_around_DNA3.count_DNA3 = -1;
        }




    }
}
