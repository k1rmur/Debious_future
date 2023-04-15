using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class ConsoleOnDoor : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button button;
    [SerializeField] private Button button2;
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private GameObject codeDoor1;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource CodeIsTrueSound;
    public bool isDoorOpen = false;


    private void Update()
    {
            if (DoorsIsOpen.DoorInCabinetIsOpen == true)
            Destroy(gameObject);
    }


    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0) && player.transform.position.z > -10 && player.transform.position.z < 25 )
        {
            codeDoor1.gameObject.SetActive(true);
        }
    }
    private void Awake()
    {
        Debug.Assert(inputField != null, $"Assign {nameof(inputField)} field in the inspector");
        Debug.Assert(button != null, $"Assign {nameof(button)} field in the inspector");
        Debug.Assert(resultText != null, $"Assign {nameof(resultText)} field in the inspector");
        Debug.Assert(inputField.contentType == TMP_InputField.ContentType.IntegerNumber, "InputType should be IntegerNumber");
        button.onClick.AddListener(OnClick);
        button2.onClick.AddListener(OnClosedPanelCode);
    }

    private void OnClick()
    {
        int result = ActionWithNumber(System.Convert.ToInt32(inputField.text));
        resultText.text = result.ToString();
        if (result == 2175)
        {
            CodeIsTrueSound.Play();
            isDoorOpen = true;
            codeDoor1.gameObject.SetActive(false);
            Destroy(gameObject);
            DoorsIsOpen.DoorInCabinetIsOpen = true;
        }

    }

    private void OnClosedPanelCode()
    {
        codeDoor1.gameObject.SetActive(false);
    }
    private int ActionWithNumber(int input)
    {
        //Здесь ваши действия с числом
        return input;
    }

    private void OnDestroy()
    {
        button.onClick.RemoveAllListeners();
    }

}




