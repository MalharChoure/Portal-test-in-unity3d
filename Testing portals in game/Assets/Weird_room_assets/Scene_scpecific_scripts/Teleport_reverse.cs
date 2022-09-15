using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_reverse : MonoBehaviour
{
    public Transform player;
    public Transform reciever;

    private bool overlapping;
    private bool check = false;
    private float ischeck = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (overlapping)
        {
            Vector3 portal_to_player = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portal_to_player);
            ischeck = portal_to_player.x;
            if (dotProduct < 0f)
            {
                check = true;
                float rotationdiff = Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationdiff += 0;
                player.Rotate(Vector3.up, rotationdiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationdiff, 0f) * portal_to_player;
                player.position = reciever.position + positionOffset;
                overlapping = false;
                bool k = true;
                float t=0;
                while(k)
                {
                    t+= Time.deltaTime;
                    if(t>0.1)
                    {
                        k = false;
                    }
                    t = 0;
                }
            }
            else
            {
                check = false;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            overlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            overlapping = false;
        }
    }
}
