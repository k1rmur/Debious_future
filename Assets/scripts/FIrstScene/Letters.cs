using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Letters : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI text;
    public GameObject letter;
    public float nowPosition;
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            letter.gameObject.SetActive(true);
            text.gameObject.SetActive(true);
            nowPosition = player.transform.position.z;
        }
    }       

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.z - 1.5f > nowPosition || nowPosition > player.transform.position.z + 1.5f)
        {
            letter.gameObject.SetActive(false);
            text.gameObject.SetActive(false);
        }
    }
}
