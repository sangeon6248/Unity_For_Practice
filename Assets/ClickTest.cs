using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    private GameObject obj;
    private void Start()
    {
        obj = GetComponent<GameObject>();   // 오브젝트를 가져옴
    }
    void OnMouseEnter()
    {
        Debug.Log("Enter");
    }
    private void OnMouseOver()
    {
        Debug.Log("Over");
    }
    private void OnMouseExit()
    {
        Debug.Log("Exit");
    }
    private void OnMouseDown()
    {
        Debug.Log("Down");
    }
    private void OnMouseUp()
    {
        Debug.Log("Up");
    }
    private void OnMouseDrag()
    {
        Debug.Log("Drag");
    }

}
