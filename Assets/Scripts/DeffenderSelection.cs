using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeffenderSelection : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DeffenderSelection>();
        foreach (DeffenderSelection button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color((float)0.3, (float)0.3, (float)0.3, (float)1);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetDeffender(defenderPrefab);
    }
}
