using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    // タグ名は変数で保存しておくと後で修正しやすい
    private string groundTag = "Ground";
    //地面と当たっているかのフラグ
    public bool isGround = false;
    //地面と触れたときにフラグをtrueに
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == groundTag) {
            isGround = true;
        }
    }

    //地面から離れたときにフラグをfalseに
    void OnTriggerExit2D(Collider2D col) {
        if (col.tag == groundTag) {
            isGround = false;
        } 
    }
}
