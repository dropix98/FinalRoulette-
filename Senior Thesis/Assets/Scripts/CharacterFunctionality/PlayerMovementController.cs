using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    // https://www.youtube.com/watch?v=tywt9tOubEY Unity's isometric guide.
    #region Variables
    private float horizontalInput;
    private float verticalInput;

    [Tooltip("Controls the player's movement speed.")]
    public float movementSpeed;

    IsoCharacterRenderer icr;
    Rigidbody2D rb;

    #endregion
    #region Methods
    // Gets the Rigidbody2D and IsoCharacterRenderer scripts
    void Awake()
    {
        icr = GetComponent<IsoCharacterRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Takes input from WASD and moves calls the MovePlayer() method
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        MovePlayer();
    }

    // Moves the player based on WASD input.
    public void MovePlayer()
    {
        Vector2 currentPos = rb.position;
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        icr.SetDirection(movement);
        rb.MovePosition(newPos);
    }

    #endregion
}
