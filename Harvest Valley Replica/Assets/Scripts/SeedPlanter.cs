using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPlanter : Tool
{
    public GameObject seed;
    
    protected override void Draw(Vector3Int cellPosition, Vector3 cellCenterPosition)
    {
        RaycastHit2D hit = Physics2D.Raycast(cellCenterPosition, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Plant"))
        {
            return;
        }

        Instantiate(seed, cellCenterPosition, Quaternion.identity);
    }
}
