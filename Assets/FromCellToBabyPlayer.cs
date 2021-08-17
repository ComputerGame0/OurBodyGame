using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromCellToBabyPlayer : MonoBehaviour
{
    [SerializeField] public GameObject One;
    [SerializeField] public GameObject[] Two = new GameObject[2];
    [SerializeField] public GameObject[] Three = new GameObject[4];
    [SerializeField] public GameObject[] Four = new GameObject[8];
    [SerializeField] public GameObject[] Five = new GameObject[12];

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
        if (collision.tag == "one")
        {
            Debug.Log("one");
            for (int i = 0; i < 2; i++)
            {
                Two[i].GetComponent<Renderer>().enabled = true;
            }
            One.GetComponent<Renderer>().enabled = false;

        }
        if (collision.tag == "two")
        {
            Debug.Log("two");
            for (int i = 0; i < 4; i++)
            {
                Three[i].GetComponent<Renderer>().enabled = true;
            }
            for (int i = 0; i < 2; i++)
            {
                Two[i].GetComponent<Renderer>().enabled = false;
            }

        }
        if (collision.tag == "three")
        {

            for (int i = 0; i < 8; i++)
            {
                Four[i].GetComponent<Renderer>().enabled = true;
            }
            for (int i = 0; i < 4; i++)
            {
                Three[i].GetComponent<Renderer>().enabled = false;
            }

        }
        if (collision.tag == "four")
        {
            Debug.Log("Four");
            for (int i = 0; i < 12; i++)
            {
                Five[i].GetComponent<Renderer>().enabled = true;
            }
            for (int i = 0; i < 8; i++)
            {
                Four[i].GetComponent<Renderer>().enabled = false;
            }

        }
        if (collision.tag == "five")
        {

            for (int i = 0; i < 12; i++)
            {
                Five[i].GetComponent<Renderer>().enabled = false;
            }          

        }
    }
}
