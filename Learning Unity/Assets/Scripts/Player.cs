using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;

    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        this.HandleMouse();
    }

    void HandleMouse()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                this.rb.AddForce(Vector2.left * this.moveSpeed);
            }
            else
            {
                this.rb.AddForce(Vector2.right * this.moveSpeed);
            }
        }
        else
        {
            this.rb.linearVelocity = Vector2.zero;
        }
    }
}
