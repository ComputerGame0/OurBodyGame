using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class ClickOnLevel : MonoBehaviour
{
   
    [SerializeField] string sceneNameLevel1;
    [SerializeField] string sceneNameLevel2;
    [SerializeField] string sceneNameLevel3;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
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
                if (hitInfo.collider.tag == "ToLevel1")
                {
                    Debug.Log("level1click");
                    SceneManager.LoadScene(sceneNameLevel1);
                }
                if (hitInfo.collider.tag == "ToLevel2")
                {
                    Debug.Log("level2click");
                    SceneManager.LoadScene(sceneNameLevel2);
                }
                if (hitInfo.collider.tag == "ToLevel3")
                {
                    Debug.Log("level3click");
                    SceneManager.LoadScene(sceneNameLevel3);
                }

            }
        }
    }
}
