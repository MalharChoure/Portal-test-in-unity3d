using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head_bob : MonoBehaviour
{

    [SerializeField]
    private bool is_moving = false;
    private Vector3 default_pos;
    private float timer = 0f;
    [SerializeField]
    private float headbob_speed = 1f;
    [SerializeField]
    private float headbob_amount = 0.15f;

    // Start is called before the first frame update
    void Start()
    {
        default_pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            is_moving = true;
        }
        else
        {
            is_moving = false;
        }
        if(is_moving)
        {
            head_bob_func();
        }
    }

    private void head_bob_func()
    {
        timer += Time.deltaTime*headbob_speed;
        transform.localPosition = new Vector3(default_pos.x, default_pos.y - headbob_amount* Mathf.Sin(timer), default_pos.z);
    }
}
