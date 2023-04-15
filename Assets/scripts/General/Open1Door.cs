using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Open1Door : MonoBehaviour
{
    [SerializeField] private GameObject TransitionDoor;
    [SerializeField] private Button buttonTrasition;
    [SerializeField] private Button buttonCancel;
    public GameObject player;
    public GameObject Door;
    private SceneChanger _SceneChanger;
    private PictureHallway _pictureHallway;
    [SerializeField] private AudioSource OpenDoorSound;
    private void Awake()
    {
        buttonCancel.onClick.AddListener(OnButtonCancelClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {

        if (Input.GetKey(KeyCode.Mouse0) && Math.Abs(player.transform.position.z - Door.transform.position.z) < 15 &&  DoorsIsOpen.DoorInCabinetIsOpen == true )
        {
            TransitionDoor.gameObject.SetActive(true);
            
        }
    }
    void OnButtonCancelClick()
    {
        TransitionDoor.gameObject.SetActive(false);
    }

}

