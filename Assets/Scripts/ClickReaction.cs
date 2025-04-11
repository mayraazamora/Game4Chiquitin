using UnityEngine;

public class ClickReaction : MonoBehaviour
{
    public GameObject sparkleEffect;
    public float sparkleDuration = 1f;

    private void OnMouseDown()
    {
        if (sparkleEffect != null)
        {
            GameObject sparkle = Instantiate(sparkleEffect, transform.position, Quaternion.identity);
            Destroy(sparkle, sparkleDuration);
        }

        Destroy(gameObject); // or animate instead
    }
}