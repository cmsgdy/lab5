using Unity.VisualScripting;
using UnityEngine;

public class boxExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    public float forceAmount = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Rigidbody found");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * forceAmount);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);
    }
   
}
