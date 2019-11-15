using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    // https://www.youtube.com/watch?v=tywt9tOubEY Unity's isometric guide. Ignore IsoCharacterRenderer things for now.
    // Start is called before the first frame update
    private float horizontalInput;
    private float verticalInput;

    public float movementSpeed;

    //IsoCharacterRenderer icr;
    Rigidbody2D rb;

    void Awake()
    {
        //icr = GetComponentInChildren<IsoCharacterRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        MovePlayer();
    }

    public void MovePlayer()
    {
        Vector2 currentPos = rb.position;
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
        inputVector = Vector2.ClampMagnitude(inputVector, 1);
        Vector2 movement = inputVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        //IsoCharacterRenderer.MovePosition(movement);
        rb.MovePosition(newPos);
    }
}
