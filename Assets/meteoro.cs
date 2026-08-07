using UnityEngine;

public class meteoro : MonoBehaviour
{
    public float minsize = 0f;
    public float maxsize = 3f;
    public Rigidbody rb;
    public float Minspeed = 1f;
    public float Maxspeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minsize, maxsize);
        transform.localScale = new Vector3(randomSize, randomSize, randomSize);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Random.onUnitSphere * Random.Range(Minspeed, Maxspeed), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
