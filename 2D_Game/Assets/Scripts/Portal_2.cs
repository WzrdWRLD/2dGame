using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal_2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerObject = gameObject;
        playerObject.SetActive(!playerObject.activeSelf);

        SceneManager.LoadScene(0);
    }
}
