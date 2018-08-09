using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour {
    public float speed = 10f;
    public float Jforce = 100f;
    public bool death;
    public GameObject resp;
    private Rigidbody2D rb;
    public GameObject player;
    private int jumps = 2;
    [SerializeField]
    GameObject canvas;



    void Start () {
        rb = GetComponent<Rigidbody2D>();
        canvas.SetActive(false);
    }
	
    private void Run(bool active)
    {
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }

    private void Jump(bool active)
    {
        if (jumps != 0 )
        {
            //rb.AddForce(transform.up * Jforce, ForceMode2D.Impulse);
            rb.velocity = Vector2.up * Jforce;
            jumps--;
        }
    }

    void OnCollisionEnter2D (Collision2D coll) {
        switch (coll.gameObject.tag)
        {
            case "Ground":
                jumps = 2;
                break;
            case "Spikes":
               death = true;
                player.SetActive(false);
                //transform.position = new Vector2(resp.transform.position.x, resp.transform.position.y);
                break;
            case "Fin":
                transform.position = new Vector2(resp.transform.position.x, resp.transform.position.y);
                break;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumps = 1;
        }
    }

    public void ShowDeathScreen()
    {
        canvas.SetActive(true);
    }

    public void Retry()
    {
        canvas.SetActive(false);
        death = false;
        transform.position = new Vector2(resp.transform.position.x, resp.transform.position.y);
        player.SetActive(true);

    }

    void Update () {
        if (Input.GetButton("Horizontal")) Run();
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
        if (death)
        {
            ShowDeathScreen();
        }
            }
        }

	

