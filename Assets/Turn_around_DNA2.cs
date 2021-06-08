using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_around_DNA2 : MonoBehaviour
{
    [SerializeField] GameObject DNA;
    [SerializeField] string player;
    [SerializeField] string left_tag;
    [SerializeField] string right_tag;
    public static int count_DNA2 = 0;

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
            count_DNA2++;
            if (this.tag == left_tag && count_DNA2 <= 3)
            {
                DNA.transform.Rotate(0, 0, 30);
            }
            if (this.tag == right_tag && count_DNA2 <= 3)
            {
                DNA.transform.Rotate(0, 0, -30);
            }



        }
    }
}
