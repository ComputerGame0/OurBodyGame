using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_around_DNA3 : MonoBehaviour
{
    [SerializeField] GameObject DNA;
    [SerializeField] string player;
    [SerializeField] string left_tag;
    [SerializeField] string right_tag;
    public static int count_DNA3 = 0;

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
        if (collision.tag == player)
        {
            Debug.Log("DNA3 "+ count_DNA3);
            count_DNA3++;
            if (this.tag == left_tag && count_DNA3 <= 3)
            {
                DNA.transform.Rotate(0, 0, 30);
            }
            /*
            if (this.tag == right_tag && count_DNA3 <= 3)
            {
                DNA.transform.Rotate(0, 0, -30);
            }
            */


        }
    }
}
