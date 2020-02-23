using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    public Grid worldGrid;

    void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int cellPosition = worldGrid.WorldToCell(worldPosition);
        Vector3 cellCenterPos = worldGrid.GetCellCenterWorld(cellPosition);

        transform.position = cellCenterPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GrowSeed(cellCenterPos);
        }
    }

    public void GrowSeed(Vector3 position)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Plant"))
        {
            Seed seed = hit.collider.GetComponent<Seed>();
            seed.Grow();
        }
    }
}
