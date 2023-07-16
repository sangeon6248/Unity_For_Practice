using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPlus : MonoBehaviour
{
    private GameObject obj;
    private float moneyValue = 0f;
    public Text text;
    void Start()
    {
        obj = GetComponent<GameObject>();
    }

    private void OnMouseDown()
    {
        moneyValue++;
        text.text = "$ : " + moneyValue;
    }
}
