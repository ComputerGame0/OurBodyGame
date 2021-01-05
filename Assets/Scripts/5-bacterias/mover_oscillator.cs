using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mover_oscillator : MonoBehaviour
{

    /*
     * Move the ball left and right,like a pendulum,increase and dicrease its speed.
    */
    Vector3 save_position;
    [SerializeField]float range = 1f;
    [SerializeField] float range2 = 5f;


    void Start()
    {
        save_position = transform.position;

    }
    void Update()
    {
        transform.position = save_position + new Vector3(0, 0, Mathf.Sin(Time.time) * range * range2);

    }

}