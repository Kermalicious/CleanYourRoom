using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class RightScript : MonoBehaviour
{
    public Tilemap tilemap;

    void OnMouseDrag()
    {
        GridLayout gridLayout = tilemap.layoutGrid;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        mousePosition.y -= 5;
        mousePosition.x += 5;
        Vector3Int cellPosition = gridLayout.WorldToCell(mousePosition) + new Vector3Int(3, 1, 0);
        Debug.Log(cellPosition);
        Vector3 rotated = tilemap.GetCellCenterWorld(cellPosition);
        rotated.z = rotated.x;
        rotated.x = (-0.5f) * rotated.x - Mathf.Sqrt(3f) * 0.5f * rotated.y;
        rotated.y = (-0.5f) * rotated.y + Mathf.Sqrt(3f) * 0.5f * rotated.z;
        rotated.z = 0;
        transform.position = rotated + new Vector3(0, 2.375f, 0);
    }
}
