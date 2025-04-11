using UnityEngine;

public class MovingAsset : MonoBehaviour
{
    public Vector2 moveDirection = Vector2.left;
    public float moveSpeed = 2f;
    public float destroyAfterTime = 10f; // auto-cleanup

    void Start()
    {
        Destroy(gameObject, destroyAfterTime);
    }

    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}