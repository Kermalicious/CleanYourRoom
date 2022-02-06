using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class BadFloorScript : MonoBehaviour
{
    public Tilemap tilemap;

    void OnMouseDrag()
    {
        GridLayout gridLayout = tilemap.layoutGrid;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        mousePosition.y -= 5;
        mousePosition.x += 5;
        Vector3Int cellPosition = gridLayout.WorldToCell(mousePosition) + new Vector3Int(4, 2, 0);
        transform.position = tilemap.GetCellCenterWorld(cellPosition) + new Vector3(0, 2.375f, 0);
    }
}