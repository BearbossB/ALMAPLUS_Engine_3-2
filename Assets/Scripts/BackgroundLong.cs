using UnityEngine;

public class BackgroundLong : MonoBehaviour
{
    #region Inspector    

    public Renderer renderer;
    public float speed = 1f;

    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        float move = Time.deltaTime * speed;
        renderer.material.mainTextureOffset += Vector2.right * move; 
    }
}
