using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    public float minX, minY, maxX, maxY;

    // Update is called once per frame
    void LateUpdate()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minX, maxX), Mathf.Clamp(player.position.y, minY, maxY), transform.position.z);
    }
}
