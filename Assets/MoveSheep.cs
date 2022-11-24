using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSheep : MonoBehaviour
{
    // privateのメンバ は一般にキャメルケース (最初小文字 + 大文字区切り)
    private Rigidbody2D rigidBody = null;

    // Start is called before the first frame update
    void Start()
    {
        // Updateでいちいち取得すると重いので,代入して保存しておく
        rigidBody = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // 変数を作る (メソッド内のみで使う変数)
        // rigidbodyの物理演算を使うためにはtransformではなくrigidbodyを使って移動する必要がある。
        Vector2 pos = rigidBody.position;
        // 前に少しずつ移動するように加算
        pos += new Vector2(0.05f,0.0f);
        // positionを更新
        rigidBody.position = pos;
    }
}
