using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSounds : MonoBehaviour
{
    [SerializeField]private AudioSource[] Sounds;

    private void Start()
    {
        StartCoroutine(WaiterFOrSounds());
    }

    private IEnumerator WaiterFOrSounds()
    {
        for (int i = 0; i < Sounds.Length; i++)
        {
            Sounds[i].Play();
            Debug.Log(Sounds[i]);
            yield return new WaitForSeconds(229);
            if (i == Sounds.Length - 1)
            {
                i = 0;
            }
        }
        

    }
        
}
