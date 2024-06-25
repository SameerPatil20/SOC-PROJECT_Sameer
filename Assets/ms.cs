using UnityEngine;

public class ms : MonoBehaviour
{
    public logics logiic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logiic= GameObject.FindGameObjectWithTag("log").GetComponent<logics>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logiic.addScore();
        }
        
    }
}
