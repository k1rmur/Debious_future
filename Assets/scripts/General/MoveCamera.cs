using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(15f, 7.2f, 0);
    [SerializeField] private Vector3 offsetRotation; 
    void Start()
    {
        Rigidbody rbPlayer = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(offsetRotation);
        transform.position = player.transform.position + offset ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
