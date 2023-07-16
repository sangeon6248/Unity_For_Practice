using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }
    private void OnMouseOver()
    {
        rend.material.color -= new Color(0.1f, 0, 0) * Time.deltaTime;
    }
    private void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
}
