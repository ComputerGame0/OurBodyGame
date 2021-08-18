using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FromCellToBabyPlayer : MonoBehaviour
{
    [SerializeField] public GameObject One;
    [SerializeField] public GameObject[] Two = new GameObject[2];
    [SerializeField] public GameObject[] Three = new GameObject[4];
    [SerializeField] public GameObject[] Four = new GameObject[8];
    [SerializeField] public GameObject[] Five = new GameObject[12];
    [SerializeField] public GameObject babyOne;
    [SerializeField] public GameObject babytwo;
    [SerializeField] public GameObject babythree;
    [SerializeField] public GameObject babyfour;
    [SerializeField] string sceneName;


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
            babyOne.GetComponent<Renderer>().enabled = true;

        }
        if (collision.tag == "babyOne")
        {
            babyOne.GetComponent<Renderer>().enabled = false;
            babytwo.GetComponent<Renderer>().enabled = true;
        }
        if (collision.tag == "babytwo")
        {
            babytwo.GetComponent<Renderer>().enabled = false;
            babythree.GetComponent<Renderer>().enabled = true;

        }
        if (collision.tag == "babythree")
        {
            babyfour.GetComponent<Renderer>().enabled = true;
            babythree.GetComponent<Renderer>().enabled = false;

        }
        if (collision.tag == "babyfour")
        {
            babyfour.GetComponent<Renderer>().enabled = false;
            SceneManager.LoadScene(sceneName);



        }
    }
}
