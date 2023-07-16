using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    private void Awake()
    {
        Camera camera = GetComponent<Camera>();     // 카메라 컴포넌트를 가져옴
        Rect rect = camera.rect;                    // 카메라의 Rect 컴포넌트를 가져옴 (x, y, width, height 등)
        float scaleheight = ((float)Screen.width / Screen.height) / ((float)9 / 16); //(가로/세로)
        float scalewidth = 1f / scaleheight;
        if (scaleheight < 1)        // 10:16처럼 가로가 더 길경우는 scaleheight가 1보다 크고 8:16일 경우 1보다 작음
        {
            rect.height = scaleheight;
            rect.y = (1f - scaleheight) / 2f;
        }
        else
        {
            rect.width = scalewidth;
            rect.x = (1f - scalewidth) / 2f;
        }
        camera.rect = rect;     // 수정 완료된 rect값을 카메라에 적용
    }
}
