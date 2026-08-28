using UnityEngine;
using UnityEngine.InputSystem;
public class nave : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float thrustforce = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void handlemovement() {
        if (Mouse.current.leftButton.isPressed){
            animator.SetBool("isMoving", true);
        }   
        else if(animator.GetBool("isMoving")){
            animator.SetBool("isMoving", false);

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

            Vector2 direction = (mousePosition - transform.position).normalized;
            transform.up = direction;
            rb.AddForce(direction * thrustforce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        handlemovement();
    }
}
