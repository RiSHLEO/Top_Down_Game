using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Knockback knockback;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        knockback = rb.GetComponent<Knockback>();
    }

    private void FixedUpdate()
    {
        MoveSlime();
    }

    private void MoveSlime()
    {
        if(knockback.GettingKnockedBack) { return; }

        rb.MovePosition(rb.position + moveDirection * (moveSpeed * Time.deltaTime));
    }

    public void MoveTo(Vector2 targetPosition)
    {
        moveDirection = targetPosition;
    }
}
