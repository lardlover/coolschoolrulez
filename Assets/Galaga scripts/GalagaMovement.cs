using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GalagaMovement : MonoBehaviour
{
    public float speed = 5;

    public GameObject bullet;

    public Image[] lives;
    public int lifeCount = 3;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }
    if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }

    if(Input.GetKeyUp(KeyCode.Space))
    {
            Instantiate(bullet, transform.position + new Vector3(0,.5f,0), Quaternion.identity);
    }
  
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.5f, 3.5f),transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy")) //|| collision.gameObject.("DropEnemy"))
        {
            lifeCount -= 1;
            if (lifeCount <= 0)
            {
                lifeCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            lives[lifeCount].enabled = false;
        }
    }
}
