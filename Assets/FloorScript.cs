using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class FloorScript : MonoBehaviour
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
        if (cellPosition.x < 0 && cellPosition.x > -12 && cellPosition.y < 0 && cellPosition.y > -12)
        {
            transform.position = tilemap.GetCellCenterWorld(cellPosition) + new Vector3(0, 2.375f, 0);
        }
        else
        {
            transform.position = mousePosition;
        }
    }
}