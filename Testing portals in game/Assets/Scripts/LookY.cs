using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    [SerializeField]
    private float _sensitivity = 1f;
    private float x_rot=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y") *  Time.deltaTime * _sensitivity;
        //Vector3 newRotation = transform.localEulerAngles;
        x_rot -= _mouseY ;
        x_rot = Mathf.Clamp(x_rot,-60f,60f);
       /* if (_mouseY>0)
        {
            newRotation.x = Mathf.Min(40, newRotation.x);
        }
        if(_mouseY<0)
        {
            newRotation.x = Mathf.Max(-40, newRotation.x);
        }*/
        transform.localEulerAngles = new Vector3(x_rot,0f,0f);
        //stransform.localRotation = Quaternion.Euler(x_rot,0f,0f);
    }
}
