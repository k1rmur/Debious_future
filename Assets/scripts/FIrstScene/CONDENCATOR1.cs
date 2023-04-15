using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CONDENCATOR1 : MonoBehaviour
{
    public static bool condencatorIsTaked = false;
    public static bool condencator2IsTaked = false;
    [SerializeField] private GameObject textOfCondTakes;
    [SerializeField] private GameObject condencator;
    [SerializeField] private AudioSource booSound;
    [SerializeField] private GameObject[] booWalls;


    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Take1Condencanor();
        }
    }
    
    private void Take1Condencanor()
    {
        if (condencatorIsTaked == false && SceneManager.GetActiveScene().name == "BasedRoom")
        {
            StartCoroutine(WaiterForShowMessage());
            condencatorIsTaked = true;
        }
        else if (condencator2IsTaked == false && SceneManager.GetActiveScene().name == "WC")
        {
            StartCoroutine(WaiterForShowMessage());
            condencator2IsTaked = true;
            booSound.Play();
        }
    }

    private IEnumerator WaiterForShowMessage()
    {
        
        textOfCondTakes.SetActive(true);
        yield return new WaitForSeconds(3);
        textOfCondTakes.SetActive(false);
    }

    private void Update()
    {
        if (condencatorIsTaked == true && SceneManager.GetActiveScene().name == "BasedRoom")
        {
            condencator.gameObject.SetActive(false);
        }
        if (condencator2IsTaked == true && SceneManager.GetActiveScene().name == "WC")
        {
            condencator.gameObject.SetActive(false);
            for (int i = 0; i < booWalls.Length; i++)
            {
                booWalls[i].gameObject.SetActive(true);
            }
        }
    }
}
