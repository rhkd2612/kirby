using UnityEngine;
using System.Collections;

public class KirbyMove : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    private int jumpCount = 0;
    private bool jumpPlus = false;
    private bool turn = false;
    public bool ground = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            moveSpeed *= 2;
        else if (Input.GetKeyUp(KeyCode.Z))
            moveSpeed /= 2;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            if (!turn)
            {
                transform.localRotation = new Quaternion(0, 180, 0, 0);
                turn = true;
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            if(turn)
            {
                transform.localRotation = new Quaternion(0, 0, 0, 0);
                turn = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCount < 1)
            {
                ground = false;
                jumpCount++;
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            jumpCount = 0;
            ground = true;
        }
    }
}
