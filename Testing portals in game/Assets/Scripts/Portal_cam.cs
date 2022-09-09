using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_cam : MonoBehaviour
{

    public Transform player_cam;
    public Transform portal;
    public Transform other_portal;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Player_offset_position = player_cam.position - other_portal.position;
        transform.position = portal.position + Player_offset_position;

        float angular_diff_beteween_portal = Quaternion.Angle(portal.rotation, other_portal.rotation);
        Quaternion portalRotationDifference = Quaternion.AngleAxis(angular_diff_beteween_portal, Vector3.up);
        Vector3 new_cam_dir = portalRotationDifference * player_cam.forward;
        transform.rotation = Quaternion.LookRotation(new_cam_dir, Vector3.up);
    }
}
