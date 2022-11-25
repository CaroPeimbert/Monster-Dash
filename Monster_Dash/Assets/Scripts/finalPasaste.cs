using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalPasaste : MonoBehaviour
{
    private void Update()
    {
        managerMeta();
    }
    public void managerMeta()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Pasaste");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
