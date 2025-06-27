using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}