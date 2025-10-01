using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 3f;
    public float distance = 5f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + new Vector3(0, 0, offset);
    }
}
