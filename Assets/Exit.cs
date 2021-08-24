using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] GameObject skip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray rayFromCameraToClickPosition = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;
            bool hasHit = Physics.Raycast(rayFromCameraToClickPosition, out hitInfo);
            if (hasHit)
            {
                if (hitInfo.collider.tag == skip.tag)
                {
                    SceneManager.LoadScene(sceneName);
                }


            }
        }

    }
}
