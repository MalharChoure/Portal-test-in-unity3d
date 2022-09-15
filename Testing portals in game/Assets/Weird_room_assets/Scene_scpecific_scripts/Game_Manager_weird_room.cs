using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager_weird_room : MonoBehaviour
{
    public Camera Cam_B;

    public Material Cam_Mat_B;
    // Start is called before the first frame update
    void Start()
    {
        if (Cam_B.targetTexture != null)
        {
            Cam_B.targetTexture.Release();
        }
        Cam_B.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        Cam_Mat_B.mainTexture = Cam_B.targetTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
