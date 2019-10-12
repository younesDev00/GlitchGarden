using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starDis;

    private void Start()
    {
        starDis = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starDis.text = stars.ToString();
    }

    public void AddStars(int increaseAmount)
    {
        stars += increaseAmount;
        UpdateDisplay();
    }
    public void DeductStars(int decreaseAmount)
    {
        if(stars >= decreaseAmount)
            stars -= decreaseAmount;
        UpdateDisplay();
    }
}
