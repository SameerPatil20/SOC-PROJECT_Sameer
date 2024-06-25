using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float  jumpStrength;
    public logics logiic;
    public bool birdIsalive =true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logiic= GameObject.FindGameObjectWithTag("log").GetComponent<logics>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsalive)
        {
            myRigidbody.velocity = Vector2.up * jumpStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Triggered by: " + collision.gameObject.name);
        logiic.quitgame();
        birdIsalive = false;
    }
}
