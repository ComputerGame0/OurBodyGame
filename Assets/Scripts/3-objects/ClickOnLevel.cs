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
    [SerializeField] string sceneNameLevel4;
    [SerializeField] string sceneNameLevel5;
    [SerializeField] string sceneNameLevel6;
    [SerializeField] string sceneNameLevel7;
    [SerializeField] string sceneNameLevel8;
    [SerializeField] string sceneNameLevel9;
    [SerializeField] string sceneNameLevel10;


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
                if (hitInfo.collider.tag == "ToLevel4")
                {
                    Debug.Log("level4click");
                    SceneManager.LoadScene(sceneNameLevel4);
                }
                if (hitInfo.collider.tag == "ToLevel5")
                {
                    Debug.Log("level5click");
                    SceneManager.LoadScene(sceneNameLevel5);
                }
                if (hitInfo.collider.tag == "ToLevel6")
                {
                    Debug.Log("level6click");
                    SceneManager.LoadScene(sceneNameLevel6);
                }
                if (hitInfo.collider.tag == "ToLevel7")
                {
                    Debug.Log("level7click");
                    SceneManager.LoadScene(sceneNameLevel7);
                }
                if (hitInfo.collider.tag == "ToLevel8")
                {
                    Debug.Log("level7click");
                    SceneManager.LoadScene(sceneNameLevel8);
                }
                if (hitInfo.collider.tag == "ToLevel9")
                {
                    Debug.Log("level9click");
                    SceneManager.LoadScene(sceneNameLevel9);
                }
                if (hitInfo.collider.tag == "ToLevel10")
                {
                    Debug.Log("level9click");
                    SceneManager.LoadScene(sceneNameLevel10);
                }



            }
        }
    }
}
