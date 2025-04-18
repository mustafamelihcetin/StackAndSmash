using UnityEngine;

/// <summary>
/// Base class for all block types. Handles common properties.
/// </summary>
[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public abstract class BlockBase : MonoBehaviour
{
    protected Rigidbody2D rb;

    [Header("Block Settings")]
    public float health = 100f;
    public float mass = 1f;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = mass;
    }

    public virtual void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
            Destroy(gameObject);
    }
}
