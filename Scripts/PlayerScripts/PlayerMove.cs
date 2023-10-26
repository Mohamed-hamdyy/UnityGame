using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed=3;
    public float leftrightSpeed = 4;
    Transform t;
    static public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {
        t= GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward,Space.World);

        if (canMove)
        {
            if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
            {

                if (this.gameObject.transform.position.x > LevelBound.left)
                {



                    transform.Translate(leftrightSpeed * Time.deltaTime * Vector3.left, Space.World);

                }
            }
            if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBound.right)
                {
                    transform.Translate(-1 * leftrightSpeed * Time.deltaTime * Vector3.left, Space.World);

                }
            }
        }
    }
}
