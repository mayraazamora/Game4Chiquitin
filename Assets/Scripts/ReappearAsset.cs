using UnityEngine;

public class ReappearAsset : MonoBehaviour
{
    public float resetXPosition = 10f;
    public float endXPosition = -10f;
    public float moveSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < endXPosition)
        {
            Vector3 newPos = transform.position;
            newPos.x = resetXPosition;
            transform.position = newPos;
        }
    }
}