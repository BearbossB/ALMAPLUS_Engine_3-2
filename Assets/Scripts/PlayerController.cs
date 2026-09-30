using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed = 5f;

    int[] scores = new int[5];

    void Start()
    {
        //bool a = true;
        //bool b = false;
        //gameObject.SetActive(a && b);

        //transform.position = Vector3.one; //(좌표 1,1,1)

        //Vector2 playerPos = transform.position;

        //playerPos.x = playerPos.x + 5;
        //transform.position = playerPos;

        //Debug.Log(playerPos.x);
        //Debug.Log(playerPos.y);

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = (i + 1) * 10;
            Debug.Log(scores[i]);
        }
    }

    void Update()
    {
        //float moveX = 0f;
        //float moveY = 0f;

        //if (Input.GetKey(KeyCode.RightArrow)) moveX = 1f;
        //if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1f;
        //if (Input.GetKey(KeyCode.UpArrow)) moveY = 1f;
        //if (Input.GetKey(KeyCode.DownArrow)) moveY = -1f;

        //Vector3 move = new Vector3(moveX, moveY, 0f);
        //transform.position += move * playerSpeed * Time.deltaTime;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        transform.position += direction.normalized * playerSpeed * Time.deltaTime;
    }
}
