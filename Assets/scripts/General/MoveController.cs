using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveController : MonoBehaviour
{
 public float _speed = 20f;
    public float ForwardInput;
    public Animator playerAnim;
    public Rigidbody playerRB;
    public Vector3 rotation;
    public string sceneName;
    public static bool BasedRoomPos;
    public bool flag = true;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        rotation = transform.eulerAngles;
        Scene scene = SceneManager.GetActiveScene();
        sceneName = SceneManager.GetActiveScene().name;
        print(sceneName);
        if (BasedRoomPos == true && sceneName == "BasedRoom" &&  flag == true)
        {
            transform.position = new Vector3(1.1f, 0, 7);
            flag = false;
        }
        else BasedRoomPos = false;
    }

    private void Update()
    {
        ForwardInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("isWalk", true);
            rotation.y = 0;
            transform.rotation = Quaternion.Euler(rotation);
            transform.Translate(Vector3.forward * Time.deltaTime * _speed * ForwardInput);
        }
        else
        {
            playerAnim.SetBool("isWalk", false);
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("isWalk", true);
            rotation.y = 180;
            transform.rotation = Quaternion.Euler(rotation);
            transform.Translate(-Vector3.forward * Time.deltaTime * _speed * ForwardInput);
        }

    }


}
