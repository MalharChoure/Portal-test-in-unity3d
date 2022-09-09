using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_mechanics : MonoBehaviour
{
    [SerializeField]
    private GameObject _Muzzleflash;
    [SerializeField]
    private AudioSource _shoot_sound_source;


    // Start is called before the first frame update
    void Start()
    {
        _Muzzleflash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _shoot_sound_source.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            _shoot_sound_source.Stop();
        }
        if (Input.GetMouseButton(0))
        {
            _Muzzleflash.SetActive(true);
        }
        else
        {
            _Muzzleflash.SetActive(false);
        }
    }
}
