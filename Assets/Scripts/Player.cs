using UnityEngine;

public class Player : MonoBehaviour
{

    float health = 50.0f;

    public float Health
    {
        get { return health; }
    }

    void TakeDamage(int value)
    {
        health -= value;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //EventManager.RunEnemyDieEvent();
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        TakeDamage(20);
        Destroy(collision.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
