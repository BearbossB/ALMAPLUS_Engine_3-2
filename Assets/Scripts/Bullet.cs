using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }

    void Update()
    {

    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }

}
