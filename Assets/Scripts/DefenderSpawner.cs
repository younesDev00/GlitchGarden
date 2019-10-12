using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;


    private void OnMouseDown()
    {
     //   Debug.Log("Mouse clicked");
        SpawnDefender(GetMousePos());
    }

    private Vector2 GetMousePos()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        worldPos = GetGridPos(worldPos);
        return worldPos;
    }

    private static Vector2 GetGridPos(Vector2 worldPos)
    {
        worldPos.x = Mathf.Round(worldPos.x);
        worldPos.y = Mathf.Round(worldPos.y);
        return worldPos;
    }

    public void SetDeffender(Defender selectedDefender)
    {
        defender = selectedDefender;
    }

    private void SpawnDefender(Vector2 mousePos)
    { 
        Defender newDefender = Instantiate(defender, mousePos, Quaternion.identity) as Defender;
    }
}
