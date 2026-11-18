using UnityEngine;

public class planeThrust : MonoBehaviour
{   
    private Rigidbody rb;

    public float thrust = 5000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
