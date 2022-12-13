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
        SpriteRenderer spriteRenderer = sheep.GetComponent<SpriteRenderer>();
        changeColor(spriteRenderer);
        moveSheep.speed *= rate;
        yield return new WaitForSeconds(5.0f);
        changeColor(spriteRenderer);
        moveSheep.speed /= rate;
    }

    void changeColor(SpriteRenderer spriteRenderer)
    {
        Debug.Log(spriteRenderer.color);
        if(rate >= 1f) {
            if (spriteRenderer.color.r >= 1f) {
                spriteRenderer.color *= new Color(1f, 1f/4f, 1f/4f);
            }
            else {
                spriteRenderer.color *= new Color(4f, 4f, 1f);
            }
        } else {
            if (spriteRenderer.color.b >= 1f) {
                spriteRenderer.color *= new Color(1f/4f, 1f/4f, 1f);
            }
            else {
                spriteRenderer.color *= new Color(1f, 4f, 4f);
            }
        }
    }
}
