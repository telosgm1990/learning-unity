using UnityEngine;

public class Block : MonoBehaviour
{
    const float posYMin = -6f;

    void Update()
    {
        this.HandlePosition();
    }

    void HandlePosition()
    {
        if (this.transform.position.y < Block.posYMin)
        {
            Destroy(this.gameObject);
        }
    }
}
