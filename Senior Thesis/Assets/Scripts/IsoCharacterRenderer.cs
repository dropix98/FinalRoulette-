using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoCharacterRenderer : MonoBehaviour
{
    #region Variables
    // Direction used for calling Animator states
    public static readonly string[] staticDirections = { "Static N", "Static NW", "Static W", "Static SW", "Static S", "Static SE", "Static E", "Static NE" };
    //public static readonly string[] runDirections = { "Static N", "Static NW", "Static W", "Static SW", "Static S", "Static SE", "Static E", "Static NE" };
    public static readonly string[] runDirections = { "Run N", " Run NW", "Run W", "Run SW", "Run S", "Run SE", "Run E", "Run NE" };
    //public static readonly string[] runDirections = { "Run N", "Run W", "Run S", "Run E" };

    Animator anim;
    int lastDirection;

    #endregion
    #region Methods
    // Gets the Animator
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Sets the direction of the player based on input
    public void SetDirection(Vector2 direction)
    {
        string[] directionArray = null;

        if (direction.magnitude < 0.01f)
            directionArray = staticDirections;
        
        else
        {
            directionArray = runDirections;
            lastDirection = DirectionToIndex(direction, 8);
        }
    
        anim.Play(directionArray[lastDirection]);
    }

    // Indexes the input Vector2 to be an index of the directionArray
    public static int DirectionToIndex(Vector2 dir, int sliceCount)
    {
        Vector2 normDir = dir.normalized;

        float step = 360f / sliceCount;

        float halfstep = step / 2;

        float angle = Vector2.SignedAngle(Vector2.up, normDir);

        angle += halfstep;

        if (angle < 0)
            angle += 360;

        float stepCount = angle / step;

        return Mathf.FloorToInt(stepCount);
    }

    //this function converts a string array to a int (animator hash) array.
    public static int[] AnimatorStringArrayToHashArray(string[] animationArray)
    {
        //allocate the same array length for our hash array
        int[] hashArray = new int[animationArray.Length];
        //loop through the string array
        for (int i = 0; i < animationArray.Length; i++)
        {
            //do the hash and save it to our hash array
            hashArray[i] = Animator.StringToHash(animationArray[i]);
        }
        return hashArray;
    }
    #endregion
}
