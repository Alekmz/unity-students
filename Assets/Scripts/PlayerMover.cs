using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveDistance;
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}