using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_movement_b : MonoBehaviour
{
    public Transform player_cam;
    public Transform player_portal_pos;
    public Transform target_portal_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 disp_dif = player_portal_pos.position - player_cam.position;
        transform.position = new Vector3((target_portal_pos.position.x + disp_dif.x), player_cam.position.y, (target_portal_pos.position.z + disp_dif.z));

        float angular_diff_beteween_portal = Quaternion.Angle(player_portal_pos.rotation, target_portal_pos.rotation);
        Quaternion portalRotationDifference = Quaternion.AngleAxis(angular_diff_beteween_portal, Vector3.up);
        Vector3 new_cam_dir = portalRotationDifference * player_cam.forward;
        Vector3 last_change = Quaternion.LookRotation(new_cam_dir, Vector3.up).eulerAngles;
        last_change = new Vector3(last_change.x, last_change.y+180, last_change.z);
        transform.rotation = Quaternion.Euler(last_change);
    }
}
