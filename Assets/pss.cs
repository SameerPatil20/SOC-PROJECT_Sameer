using UnityEngine;

public class pss : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate =4;
    private float timer=0;
    public float heightoffset=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer=0;
             spawnpipe();
        }
        // Instantiate(pipe, transform.position,transform.rotation);
    }
    void spawnpipe()
    {
        float lowestpoint=transform.position.y - heightoffset;
        float highestpoint=transform.position.y + heightoffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0),transform.rotation);
    }
}
