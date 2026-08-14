using UnityEngine;

public class meteoro : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float minsize = 0.5f;
    public float maxsize = 2f;
    public Rigidbody2D rb;
    public float minSpeed = 10f;
    public float maxSpeed = 30f;
    public float minTorque = -40f; 
    public float maxTorque = 40f;
    private Vector2 RandomSpeed;
    void Start()
    {
        float radomSize = Random.Range(minsize, maxsize);

        float Randomspeed = Random.Range(minSpeed, maxSpeed);

        float randomtorque = Random.Range(minTorque, maxTorque);

        Vector2 RandomDirection = Random.insideUnitCircle.normalized;

        transform.localScale = new Vector3(radomSize, radomSize, 1);

        transform.localRotation = Quaternion.Euler(1, 1, randomtorque);

        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(RandomDirection * RandomSpeed);

        rb.AddTorque(randomtorque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
