using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private CircleCollider2D circleCollider2D;
    public float rate;
    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        circleCollider2D = GetComponent<CircleCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "hitsuji_dot") {
            spriteRenderer.enabled = false;
            circleCollider2D.enabled = false;
            StartCoroutine(changeSpeed(col));
        }
    }

    IEnumerator changeSpeed(Collider2D sheep)
    {
        MoveSheep moveSheep =  sheep.GetComponent<MoveSheep>();
        moveSheep.speed *= rate;
        yield return new WaitForSeconds(3.0f);
        moveSheep.speed /= rate;
    }
}
