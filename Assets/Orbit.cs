using UnityEngine;

public class Orbit : MonoBehaviour
{
    // 自转速度（度/秒）
    public float rotationSpeed = 20f;

    void Update()
    {
        // 让整个系统绕 Y 轴旋转
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}