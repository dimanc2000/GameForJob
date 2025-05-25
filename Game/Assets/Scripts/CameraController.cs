using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;

    private void Awake()
    {
        if (!player) player = FindObjectOfType<Men>().transform;
    }

    private void Update()
    {
        pos = transform.position;
        pos.x = player.position.x;
        pos.y = player.position.y;
        pos.z = -10f;
        transform.position = pos;
        //pos = player.position;
        //pos.x += 1f;
        //pos.y += 1.5f;
        //pos.z = -10f;
        //transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
