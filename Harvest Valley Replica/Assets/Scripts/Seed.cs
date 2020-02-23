using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public int growLevel;

    private void Start()
    {
        growLevel = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            ReadyHarvest();
        }
    }

    public void Grow()
    {
        if (growLevel < sprites.Length - 1)
        {
            ++growLevel;
            spriteRenderer.sprite = sprites[growLevel];
        }
    }

    public void ReadyHarvest()
    {
        growLevel = sprites.Length - 1;
        spriteRenderer.sprite = sprites[growLevel];
    }
}
