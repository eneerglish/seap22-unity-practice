using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private GameObject sheep;
    // Start is called before the first frame update
    void Start()
    {
        sheep = GameObject.Find("hitsuji_dot");
    }

    // Update is called once per frame
    void Update()
    {
        // ひつじの座標を取得
        Vector3 pos = sheep.transform.position;
        // ひつじの座標のままだと 俯瞰して見られないので、
        // z座標を-10だけずらす
        this.transform.position = pos + new Vector3(0.0f, 0.0f, -10f);
    }
}
