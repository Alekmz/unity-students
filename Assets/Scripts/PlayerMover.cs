using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float gravityScale = 4;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}