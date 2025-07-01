using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float Velocidade = 20f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Velocidade * Time.deltaTime);
        }
    }
}