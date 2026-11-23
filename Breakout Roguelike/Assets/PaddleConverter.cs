using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 12f;
    [SerializeField] private float boundaryX = 7.5f;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, -boundaryX, boundaryX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}