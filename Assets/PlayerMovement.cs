using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
        transform.position = new Vector3(transform.position.x,
                            Mathf.Clamp(transform.position.y, -3.5f, 3.5f),
                            transform.position.z);
    }
}
    