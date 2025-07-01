using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 23f;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}