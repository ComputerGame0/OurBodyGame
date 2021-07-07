using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooth_Trigger : MonoBehaviour
{
    [SerializeField] string trigger_player;
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
            Destroy(this.gameObject);

        }
    }
}
