using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PictureHallway : MonoBehaviour
{
    [SerializeField] private Door _doorLeft;
    [SerializeField] private Door _doorRight;
    [SerializeField] private Button Cancel;
    [SerializeField] private Button True;
    [SerializeField] private GameObject picture;
    [SerializeField] private AudioSource OpenOperationDoorSound;
    private bool _pictureComplete = false;
    Buttons[] arrayButtons = new Buttons[4];
    [SerializeField] private Button[] allButtons = new Button[4];
    public bool PictureComplete => _pictureComplete;
    private static bool isDoorOpened = false;

    private void Awake()
    {
        arrayButtons[0] = new Buttons(270);
        arrayButtons[1] = new Buttons(0);
        arrayButtons[2] = new Buttons(0);
        arrayButtons[3] = new Buttons(0);
    }
    private void Start()
    {
        Cancel.onClick.AddListener(Closed);
        True.onClick.AddListener(TrueMove);
        allButtons[0].onClick.AddListener(() => QuaternionRotation(0));
        allButtons[1].onClick.AddListener(() => QuaternionRotation(1));
        allButtons[2].onClick.AddListener(() => QuaternionRotation(2));
        allButtons[3].onClick.AddListener(() => QuaternionRotation(3));
    }
    private void Update()
    {
        Cancel.onClick.AddListener(Closed);
        True.onClick.AddListener(TrueMove);                   
    }

    private void QuaternionRotation(int i)
    {
        allButtons[i].transform.rotation = Quaternion.Euler(arrayButtons[i].EditRotationButton());
    }


    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isDoorOpened == false)
        {
            picture.gameObject.SetActive(true);
        }
    }
    void Closed()
    {
        picture.gameObject.SetActive(false);
    }

    void SoundDoorOpen()
    {
        OpenOperationDoorSound.Play();
    }
    
    void TrueMove()
    {
        for (int j = 0; j < allButtons.Length; j++)
        {
           if (allButtons[0].transform.rotation.z == 0 && allButtons[1].transform.rotation.z == 0 && allButtons[2].transform.rotation.z == 0 && allButtons[3].transform.rotation.z == 0)
            {
                picture.gameObject.SetActive(false);
                _pictureComplete = true;
                SoundDoorOpen();
                _doorLeft.OpenDoor();
                _doorRight.OpenDoor();
                isDoorOpened = true;
            }
        }
    }


}
