using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooth_Trigger : MonoBehaviour
{
    [SerializeField] string trigger_player;
    [SerializeField] public static int NumOfBlack = 6;

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
        if (collision.tag == trigger_player)
        {
            Debug.Log("innng");
            NumOfBlack = NumOfBlack - 1;
            Destroy(this.gameObject);

        }
    }
}
