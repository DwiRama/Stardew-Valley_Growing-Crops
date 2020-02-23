using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PickAxe : Tool
{
    public Tilemap wetTilemap;
    
    protected override void Draw(Vector3Int cellPosition, Vector3 cellCenterPosition)
    {
        targetDrawTilemap.SetTile(cellPosition, null);
        wetTilemap.SetTile(cellPosition, null);

        RaycastHit2D hit = Physics2D.Raycast(cellCenterPosition, Vector2.zero);
        
        if (hit.collider != null && hit.collider.CompareTag("Plant"))
        {
            Destroy(hit.collider.gameObject);
        }
    }    
}
