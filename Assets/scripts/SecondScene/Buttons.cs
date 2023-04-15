using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Buttons : InterfacePicture
{    
    private Vector3 PlusRotation;
    public Vector3 rotationButton;
    public Vector3 EditRotationButton()
    {
        PlusRotation.z += 90;
        if (PlusRotation.z == 360)
        {
            PlusRotation.z = 0;
        }
        Debug.Log(PlusRotation.z);
        return PlusRotation;
        
    }
    public Buttons(float rotationButton)
    {
        this.rotationButton.z = rotationButton;
    }
}

