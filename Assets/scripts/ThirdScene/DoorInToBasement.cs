using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorInToBasement : MonoBehaviour
{
    [SerializeField] private GameObject closedDoor;
    [SerializeField] private GameObject doorInside;
    [SerializeField] private Button buttonDoorTransition;
    [SerializeField] private Button buttonDoorClosed;
    [SerializeField] private Button buttonCancel;
    [SerializeField] private Button buttonCancel2;
    [SerializeField] private GameObject transition;
    [SerializeField] private Button closedOnTransition;

    private void Start()
    {
        buttonDoorClosed.onClick.AddListener(Open);
        closedOnTransition.onClick.AddListener(Closed);
        buttonCancel.onClick.AddListener(Closed);
        buttonCancel2.onClick.AddListener(Closed);
        buttonDoorTransition.onClick.AddListener(TransitionOnBasement);

    }
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Switchbox.switchWorked)
        {
            closedDoor.gameObject.SetActive(true);
        }
    }

    private void TransitionOnBasement()
    {
        transition.gameObject.SetActive(true);
    }

    private void Open()
    {
        doorInside.gameObject.SetActive(true);
        closedDoor.gameObject.SetActive(false);
    }

    private void Closed()
    {
        doorInside.gameObject.SetActive(false);
        closedDoor.gameObject.SetActive(false);
        transition.gameObject.SetActive(false);
    }


}
