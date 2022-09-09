using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private CharacterController _controller;
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private float _maxspeed = 3.5f;
    private float _gravity = 9.8f;
    //private NavMeshAgent _navmeshagent;
    //[SerializeField]
    // private GameObject _Hit_Marker;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        //_navmeshagent = GetComponent<NavMeshAgent>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if(Input.GetKey(KeyCode.S))
        {
            _speed = _maxspeed / 2;
        }
        else
        {
            _speed = _maxspeed;
        }
    }
    void CalculateMovement()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * _speed;
        velocity.y -= _gravity;

        velocity = transform.TransformDirection(velocity);
        _controller.Move(velocity * Time.deltaTime);
        //transform.position = _navmeshagent.nextPosition;
    }
}
   

