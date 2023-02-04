using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBlock : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite itemBlock;
    public Sprite emptyBlock;
    public bool hasItem;

    private void Start() {
        if (hasItem) {
            spriteRenderer.sprite = itemBlock;
        }
        else {
            spriteRenderer.sprite = emptyBlock;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.gameObject.tag == "Player") {
            Debug.Log("Hit block");
            hasItem = false;
            spriteRenderer.sprite = emptyBlock;
        }
    }
}
