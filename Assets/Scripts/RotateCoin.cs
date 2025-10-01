using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int rotateSpeed;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
