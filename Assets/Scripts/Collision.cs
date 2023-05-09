using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [Header("Layers")]
    public LayerMask groundLayer;
    public LayerMask spikesLayer;

    [Space]

    public bool onGround;
    public bool onWall;
    public bool onRightWall;
    public bool onLeftWall;
    public int wallSide;
    public bool onSpikes;

    [Space]
    //public float collisionRadius = 0.25f;
    //public Vector2 bottomOffset, rightOffset, leftOffset;
    [Header("Collision")]
    public bool showLeftGizmo, showRightGizmo, showBottomGizmo, showSpikesGizmo;
    public Vector2 leftBoxOffset, leftBoxSize;
    public Vector2 rightBoxOffset, rightBoxSize;
    public Vector2 bottomBoxOffset, bottomBoxSize;
    public Vector2 spikesBoxOffset, spikesBoxSize;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //onSpikes = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, spikesLayer)
        //    || Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, spikesLayer)
        //    || Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, spikesLayer);

        onSpikes = Physics2D.OverlapBox((Vector2)transform.position + spikesBoxOffset, spikesBoxSize, 0, spikesLayer);

        if (!onSpikes)
        {
            //onGround = Physics2D.OverlapCircle((Vector2)transform.position + bottomOffset, collisionRadius, groundLayer);
            onGround = Physics2D.OverlapBox((Vector2)transform.position + bottomBoxOffset, bottomBoxSize, 0, groundLayer);

            //onWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, groundLayer)
            //    || Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, groundLayer);
            onWall = Physics2D.OverlapBox((Vector2)transform.position + rightBoxOffset, rightBoxSize, 0, groundLayer)
                    || Physics2D.OverlapBox((Vector2)transform.position + leftBoxOffset, leftBoxSize, 0, groundLayer);


            //onRightWall = Physics2D.OverlapCircle((Vector2)transform.position + rightOffset, collisionRadius, groundLayer);
            onRightWall = Physics2D.OverlapBox((Vector2)transform.position + rightBoxOffset, rightBoxSize, 0, groundLayer);
            //onLeftWall = Physics2D.OverlapCircle((Vector2)transform.position + leftOffset, collisionRadius, groundLayer);
            onLeftWall = Physics2D.OverlapBox((Vector2)transform.position + leftBoxOffset, leftBoxSize, 0, groundLayer);

            wallSide = onRightWall ? -1 : 1;
        }
        else
        {
            onGround = false;
            onWall = false;
            onRightWall = false;
            onLeftWall = false;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        // var positions = new Vector2[] { bottomOffset, rightOffset, leftOffset };
        if (showBottomGizmo)
        {
            Gizmos.DrawWireCube((Vector2)transform.position + bottomBoxOffset, bottomBoxSize);
        }
        if (showRightGizmo)
        {
            Gizmos.DrawWireCube((Vector2)transform.position + rightBoxOffset, rightBoxSize);
        }
        if (showLeftGizmo)
        {
            Gizmos.DrawWireCube((Vector2)transform.position + leftBoxOffset, leftBoxSize);
        }

        if (showSpikesGizmo)
        {
            Gizmos.DrawWireCube((Vector2)transform.position + spikesBoxOffset, spikesBoxSize);
        }

        //Gizmos.DrawWireSphere((Vector2)transform.position  + bottomOffset, collisionRadius);
        //Gizmos.DrawWireSphere((Vector2)transform.position + rightOffset, collisionRadius);
        //Gizmos.DrawWireSphere((Vector2)transform.position + leftOffset, collisionRadius);
    }
}
