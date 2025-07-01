using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}