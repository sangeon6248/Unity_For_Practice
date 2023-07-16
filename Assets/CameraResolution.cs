using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    private void Awake()
    {
        Camera camera = GetComponent<Camera>();     // ī�޶� ������Ʈ�� ������
        Rect rect = camera.rect;                    // ī�޶��� Rect ������Ʈ�� ������ (x, y, width, height ��)
        float scaleheight = ((float)Screen.width / Screen.height) / ((float)9 / 16); //(����/����)
        float scalewidth = 1f / scaleheight;
        if (scaleheight < 1)        // 10:16ó�� ���ΰ� �� ����� scaleheight�� 1���� ũ�� 8:16�� ��� 1���� ����
        {
            rect.height = scaleheight;
            rect.y = (1f - scaleheight) / 2f;
        }
        else
        {
            rect.width = scalewidth;
            rect.x = (1f - scalewidth) / 2f;
        }
        camera.rect = rect;     // ���� �Ϸ�� rect���� ī�޶� ����
    }
}
