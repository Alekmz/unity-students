using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 9f;
// modifiquei a velocidade aumentanodo ela pra 9 
    void Update()
    {
        if (Input.GetKey(KeyCode.  r ))
// modifiquei a tecla que realiza a ação para "r"
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}