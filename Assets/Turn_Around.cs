using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Around : MonoBehaviour
{
    [SerializeField] GameObject Butterfly;
    [SerializeField] string player;
    [SerializeField] string left_tag;
    [SerializeField] string right_tag;
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
            if (this.tag == left_tag)
            {
                Butterfly.transform.Rotate(0, 0, 30);
            }
            if (this.tag == right_tag)
            {
                Butterfly.transform.Rotate(0, 0, -30);
            }
            Destroy(this.gameObject);


        }
    }
}
