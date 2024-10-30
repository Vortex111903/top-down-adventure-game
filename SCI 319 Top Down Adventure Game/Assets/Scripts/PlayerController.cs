using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;
    
    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("w")) 
        {
            newPosition.y += speed;
            sr.sprite = upSprite;
        }
        if (Input.GetKey("a"))
        {
            newPosition.x -= speed;
            sr.sprite = leftSprite;
        }
        if (Input.GetKey("s"))
        {
            newPosition.y -= speed;
            sr.sprite = frontSprite;
        }
        if (Input.GetKey("d"))
        {
            newPosition.x += speed;
            sr.sprite = rightSprite;
        }
        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag.Equals("Door 1")) 
        {
            SceneManager.LoadScene(2);
        }
    }
}


