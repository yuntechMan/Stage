using UnityEngine;
using System.Collections;

/// <summary>
/// 鼠标控制相机旋转
/// </summary>
public class cameraT5 : MonoBehaviour
{
    private void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        if (x != 0 || y != 0)
            RotateView(x, y);

    }

    public float speed = 10;
    private void RotateView(float x, float y)
    {
        x *= speed * Time.deltaTime;
        y *= speed * Time.deltaTime;
        //沿Y轴旋转
        transform.Rotate(-y, 0, 0);
        //左右旋转，需沿直接坐标系y轴。不然会像坐飞机倒转一样晕视角
        transform.Rotate(0, x, 0, Space.World);
    }

}