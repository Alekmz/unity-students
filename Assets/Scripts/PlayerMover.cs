using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}