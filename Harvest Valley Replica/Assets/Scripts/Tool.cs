using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tool : MonoBehaviour
{
    public new string name;
    public Tilemap baseTilemap;
    public TileBase baseTile;

    public Tilemap targetDrawTilemap;
    public TileBase drawTile;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPosition = targetDrawTilemap.WorldToCell(worldPosition);
            Vector3 cellCenterPosition = targetDrawTilemap.GetCellCenterWorld(cellPosition);

            if (Drawable(cellPosition, cellCenterPosition))
            {
                Draw(cellPosition, cellCenterPosition);
            }
        }
    }

    protected virtual void Draw(Vector3Int cellPosition, Vector3 cellCenterPosition)
    {
        targetDrawTilemap.SetTile(cellPosition, drawTile);
    }

    protected virtual bool Drawable (Vector3Int cellPos, Vector3 cellCenterPosition)
    {
        TileBase tile = baseTilemap.GetTile<TileBase>(cellPos);

        if (tile == baseTile)
        {
            return true;
        }

        return false;
    }
}
