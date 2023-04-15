using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField]
    private GameObject _transitionDoor;
    [SerializeField]
    private Button _buttonCancel;

    private GameObject _player;

    private static bool _opened = false;
    public bool Opened => _opened;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _buttonCancel.onClick.AddListener(OnButtonCancelClick);
    }

    private void ActivateTransition()
    {
        _transitionDoor.SetActive(true);
    }

    private void DeactivateTransition()
    {
        _transitionDoor.SetActive(false);
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && Mathf.Abs(_player.transform.position.z - transform.position.z) < 15 && _opened)
        {
            ActivateTransition();
        }
    }

    public void OpenDoor()
    {
        _opened = true;

    }

    public void CloseDoor()
    {
        _opened = false;
    }

    private void OnButtonCancelClick()
    {
        DeactivateTransition();
    }


}
