using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class TakesRedWire : MonoBehaviour
{
    public static bool redWireIsTaked = false;
  //  [SerializeField] private GameObject Cabinet;
    [SerializeField] private GameObject ShowMessageOfTakes;
    [SerializeField] private GameObject RedWire;


    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            TakeRedWire();
        }
    }
    private void TakeRedWire()
    {
        if (redWireIsTaked == false)
        {
            StartCoroutine(CourutineWaiter());
            redWireIsTaked = true;
        }
    }

    private IEnumerator CourutineWaiter()
    {
        ShowMessageOfTakes.gameObject.SetActive(true);
        RedWire.gameObject.SetActive(false);
        yield return new WaitForSeconds(3);
        ShowMessageOfTakes.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (redWireIsTaked == false)
        {
            RedWire.gameObject.SetActive(true);
        }
        else
        {
            RedWire.gameObject.SetActive(false);
        }
    }
}
