using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -1);
    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
