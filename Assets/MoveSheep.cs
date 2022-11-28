using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSheep : MonoBehaviour
{
    // privateのメンバ は一般にキャメルケース (最初小文字 + 大文字区切り)
    private Rigidbody2D rigidBody = null;
    private GroundCheck groundCheck;
    public float speed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        // Updateでいちいち取得すると重いので, 代入して保存しておく
        rigidBody = this.GetComponent<Rigidbody2D>();
        groundCheck = GameObject.Find("GroundCheck").GetComponent<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    { 
        Vector2 pos = rigidBody.position;

        if (Input.GetKey (KeyCode.D)) 
        {
            pos.x += speed;
        }

        if (Input.GetKey (KeyCode.A))
        {
            pos.x -= speed;
        }

        if (groundCheck.isGround && Input.GetKeyDown (KeyCode.Space)) 
        {
            rigidBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        } else {
            rigidBody.position = pos;
        }
    }
     void Awake() { 
        Application.targetFrameRate = 30;
     }
}
