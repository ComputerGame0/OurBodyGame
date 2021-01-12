using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    [SerializeField] public Text set1 = null;
    [SerializeField] float Show_time = 2f;
    void Start()
    {

        StartCoroutine(ShowMessage(Show_time));

    }
    IEnumerator ShowMessage(float delay)
    {
        yield return new WaitForSeconds(delay);
        set1.text = "*Use the arrow keys to move < > ^\n*Use the shift button to increase the player's speed.\n";
        yield return new WaitForSeconds(delay);
        set1.text = "\n\nGood luck!";
        yield return new WaitForSeconds(delay);

        Destroy(set1);



    }


    // Update is called once per frame
    void Update()
    {

    }
}
