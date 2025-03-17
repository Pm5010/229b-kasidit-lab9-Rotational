using UnityEngine;

public class magnusfect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Kick();
            
            applyMagnusEffect();
        }
        
    }

    void Kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }
    
    void applyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(velocity, spin);
        
        rb.AddForce(magnusForce);
    }
}
