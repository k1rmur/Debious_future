using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Switchbox : MonoBehaviour
{
    [SerializeField] private GameObject switchCap;
    [SerializeField] private GameObject switchInside;
    [SerializeField] private Button switchCapButton;
    [SerializeField] private Button switchInsideButton;
    [SerializeField] private Button switchClosedButton;
    [SerializeField] private Button switchClosedButton2;
    [SerializeField] private AudioSource switchOpenSound;
    [SerializeField] private GameObject switchDestroyerOnScene;
    [SerializeField] private GameObject redWire;
    [SerializeField] private GameObject Condencator1;
    [SerializeField] private GameObject Condencator2;
    [SerializeField] private GameObject lightOnShkaf;
    [SerializeField] private GameObject audioGenerator;
    private static bool flagForRedWireInsert = false;
    private static bool flagForCondencator1 = false;
    private static bool flagForCondencator2 = false;
    private static bool flagForAudioListener = false;
    private static bool _swithIsWorked = false;
    public static bool switchWorked => _swithIsWorked;

    void Start()
    {
        switchCapButton.onClick.AddListener(SwitchOpenButton);
        switchClosedButton.onClick.AddListener(SwitchInsideCloseButton);
        switchClosedButton2.onClick.AddListener(SwitchCapCloseButton);
        switchInsideButton.onClick.AddListener(SwitchClickInside);
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            switchCap.gameObject.SetActive(true);
            switchDestroyerOnScene.gameObject.SetActive(false);
        }
    }

    private void SwitchOpenButton()
    {
        switchCap.gameObject.SetActive(false);
        switchInside.gameObject.SetActive(true);
        switchOpenSound.Play();
        if (TakesRedWire.redWireIsTaked == true && flagForRedWireInsert == true)
        {
            redWire.gameObject.SetActive(true);
        }
        if (CONDENCATOR1.condencatorIsTaked == true && flagForCondencator1 == true)
        {
            Condencator1.gameObject.SetActive(true);
        }
        if (CONDENCATOR1.condencator2IsTaked == true && flagForCondencator2 == true)
        {
            Condencator2.gameObject.SetActive(true);
        }
    }

    private void SwitchClickInside()
    {
        if (TakesRedWire.redWireIsTaked == true)
        {
            redWire.gameObject.SetActive(true);
            flagForRedWireInsert = true;
        }
        if (CONDENCATOR1.condencatorIsTaked == true)
        {
            Condencator1.gameObject.SetActive(true);
            flagForCondencator1 = true;
        }
        if (CONDENCATOR1.condencator2IsTaked == true)
        {
            Condencator2.gameObject.SetActive(true);
            flagForCondencator2 = true;
        }
    }
    private void SwitchCapCloseButton()
    {
        switchCap.gameObject.SetActive(false);
    }
    private void SwitchInsideCloseButton()
    {
        switchInside.gameObject.SetActive(false);
        switchDestroyerOnScene.gameObject.SetActive(true);
        switchOpenSound.Play();
    }

    private void Update()
    {
        if (flagForCondencator1 == true && flagForCondencator2 == true && flagForRedWireInsert == true && flagForAudioListener == false)
        {
            audioGenerator.gameObject.SetActive(true);
            flagForAudioListener = true;
        }
        if (flagForCondencator1 == true && flagForCondencator2 == true && flagForRedWireInsert == true)
        {
            lightOnShkaf.gameObject.SetActive(true);
            _swithIsWorked = true;
        }
    }
}
