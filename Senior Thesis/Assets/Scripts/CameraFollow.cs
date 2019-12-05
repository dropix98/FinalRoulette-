using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private Transform player;

    [Tooltip("Maximum and minimum X and Y values that the camera can travel.")]
    public float minX, minY, maxX, maxY;

    #endregion
    #region Methods
    // Gets the player's transform
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void LateUpdate()
    {
        UpdatePosition();
    }

    // Updates the position of the camera within the clamped positions
    void UpdatePosition()
    {
        transform.position = new Vector3(Mathf.Clamp(player.position.x, minX, maxX), Mathf.Clamp(player.position.y, minY, maxY), transform.position.z);
    }

    #endregion
}
