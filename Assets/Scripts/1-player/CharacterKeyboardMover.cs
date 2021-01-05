using System.Collections;
using UnityEngine;
using UnityEngine.UI;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover: MonoBehaviour {
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float _speed = 3.5f;
    [SerializeField] float _speeder = 15f;
    [SerializeField] float _gravity = 9.81f;
    [SerializeField] float Speed_time = 3f;
    [SerializeField] public Text Text_velocity = null;
    private float temp;


    private CharacterController _cc;
    private float save_velocity;
    void Start() {
        _cc = GetComponent<CharacterController>();
        save_velocity = _speed;
        Text_velocity.text = "Velocity:" + this.velocity.z;

    }

    Vector3 velocity;


    IEnumerator AddVelocity(float delay)
    {
        yield return new WaitForSeconds(delay);
        _speed = save_velocity;
        temp = this.velocity.z;
        if (this.velocity.z < 0)
        {
            temp = temp * -1;
        }
        Text_velocity.text = "Velocity:" + temp;
        

    }

    void Update()  {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            _speed = _speeder;  //new Velocity
            temp = this.velocity.z;
            if (this.velocity.z < 0)
            {
                temp = temp * -1;
            }
            Text_velocity.text = "Velocity:" + temp;
            StartCoroutine(AddVelocity(Speed_time));  //time for new Velocity
        }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            //if (x == 0 && z == 0) return;
            velocity.x = x * _speed;
            velocity.z = z * _speed;
            if (!_cc.isGrounded)
            {
                velocity.y -= _gravity * Time.deltaTime;
            }
            // Click Up: velocity = (0,0,1)
            velocity = transform.TransformDirection(velocity);
        temp = this.velocity.z;
        if (this.velocity.z < 0)
        {
            temp = temp * -1;
        }
        Text_velocity.text = "Velocity:" + temp;
        //Debug.Log("velocity="+velocity+" isGrounded="+ _cc.isGrounded);
        _cc.Move(velocity * Time.deltaTime);
        
    }
}
