using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float speed;
    private SpriteRenderer sr;
    public bool hasAcorn = false;
    public bool hasTwig = false;
    public bool hasKey = false;

    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;

   public AudioSource soundEffects;
   public AudioSource soundEffects2;
    //public AudioClip doorOpen;
    //public AudioClip itemCollect;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
 soundEffects = GetComponent<AudioSource>();
        soundEffects2 = GetComponent<AudioSource>();
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
          soundEffects2.Play();
        }
        if (collision.gameObject.tag.Equals("Acorn"))
        {
            hasAcorn = true;
          soundEffects.Play();
        }
        if (collision.gameObject.tag.Equals("Twig"))
        {
            hasTwig = true;
            soundEffects.Play();
        }
        if (collision.gameObject.tag.Equals("Door 2") && hasTwig == true && hasAcorn == true)
        {
            SceneManager.LoadScene(3);
           soundEffects2.Play();
        }
        if (collision.gameObject.tag.Equals("Key"))
        {
            hasKey = true;
            soundEffects.Play();

        }
        if (collision.gameObject.tag.Equals("Exit") && hasKey == true )
        {
            SceneManager.LoadScene(4);
            soundEffects2.Play();
        }
    }   
}


