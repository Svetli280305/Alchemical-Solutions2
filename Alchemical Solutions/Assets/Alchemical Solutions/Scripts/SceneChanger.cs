using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] int sceneToLoad;

    bool active = false;
    public bool outOfRange = true;
    [SerializeField] GameObject SceneChangerGUI;

    private void Update()
    {
        if(active == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Is in trigger");
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            active = true;
            SceneChangerGUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            active = false;
            SceneChangerGUI.SetActive(false);
        }
    }
}
